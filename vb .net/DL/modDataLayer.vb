Imports System.IO
Imports System.Xml
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Module modDataLayer
    Public Function GetConnectionString() As String
        GetConnectionString = ""
        Try
            Dim MEDIAXML As New XmlDocument()
            MEDIAXML.Load(Application.StartupPath & "\ServerConnection.xml")
            Dim XMLNode As XmlNode = MEDIAXML.SelectSingleNode("ConnectionString")
            If XMLNode IsNot Nothing Then GetConnectionString = (XMLNode.ChildNodes(0).InnerText)
        Catch e As Exception
            Console.WriteLine("Error: {0}", e.ToString())
        End Try
    End Function
    Public Function GETDATATABLE(ByVal strquery As String) As DataTable
        Dim conn As MySqlConnection = Nothing
        Try
            GETDATATABLE = Nothing
            conn = New MySqlConnection(GetConnectionString())
            Using conn
                conn.Open()
                Using sda As New MySqlDataAdapter(strquery, conn)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    GETDATATABLE = dt
                End Using
            End Using
        Catch ex As Exception
            GETDATATABLE = Nothing
            Throw ex
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Function
    Public Function GETDATATABLE(ByVal Command As MySqlCommand, Optional ByVal strTableName As String = "table_name") As DataTable
        Dim conn As MySqlConnection = Nothing
        Try
            GETDATATABLE = Nothing
            conn = New MySqlConnection(GetConnectionString())
            Using conn
                conn.Open()
                Command.Connection = conn
                Using sda As New MySqlDataAdapter(Command)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    GETDATATABLE = dt
                End Using
            End Using
        Catch ex As Exception
            GETDATATABLE = Nothing
            Throw ex
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Function
    Public Function ExecuteNonQuery(strquery As String) As Boolean
        Dim conn As MySqlConnection = Nothing
        Try
            ExecuteNonQuery = False
            conn = New MySqlConnection(GetConnectionString())
            Using conn
                conn.Open()
                Using ExecuteQuery As New MySqlCommand(strquery, conn)
                    ExecuteQuery.ExecuteNonQuery()
                    conn.Close()
                    ExecuteNonQuery = True
                End Using
            End Using
        Catch ex As Exception
            ExecuteNonQuery = False
            Throw ex
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Function
    Public Function DirectoryForLogFile(LogFileName As String) As String
        Try
            If Not Directory.Exists(Application.StartupPath & "\logFiles") Then Directory.CreateDirectory(Application.StartupPath & "\logFiles")
            Dim Path As String = Application.StartupPath & "\logFiles\" & LogFileName
            If File.Exists(Path) Then
                Return Path
            Else
                Using File.Create(Path) : End Using
                Return Path
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Module
