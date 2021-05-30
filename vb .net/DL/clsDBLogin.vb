Imports MySql.Data.MySqlClient
Public Class clsDBLogin
    Public Shared Function GetUser(UserName, password) As DataTable
        GetUser = Nothing
        Try
            Using cmd As New MySqlCommand("useradmin.SpGetUser")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PUsername", UserName)
                cmd.Parameters.AddWithValue("@Ppassword", password)
                GetUser = modDataLayer.GETDATATABLE(cmd)
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
