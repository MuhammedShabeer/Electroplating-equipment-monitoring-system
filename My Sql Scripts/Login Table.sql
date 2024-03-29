CREATE DATABASE `useradmin`;
CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_user_mst` (
  `intUserid`      INT NOT NULL AUTO_INCREMENT,
  `chvUsername`    VARCHAR(255) NOT NULL,
  `chvPassword`    VARCHAR(32) NOT NULL,
  `intUserType`    int NOT NULL,
  `chvEmail`       VARCHAR(255) NULL,
  `dtmCreate_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intUserid`));
CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_UserType_mst` (
  `intUserTypeId` INT NOT NULL AUTO_INCREMENT,
  `chvUserType`   VARCHAR(255) NOT NULL,
  `intUserType`   int NOT NULL,
  `dtmCreateTime` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intUserTypeid`));
REPLACE INTO useradmin.tbl_UserType_mst VALUES (1,'Administrator',1,CURDATE()); 
REPLACE INTO useradmin.tbl_user_mst VALUES (1,'admin','123',1,null,CURDATE()); 
CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_Monitorscreen_mst` (
  `intMonitorscreenId`       INT NOT NULL AUTO_INCREMENT,
  `intSlotNumber`            INT  NULL,
  `chvCraft`                 VARCHAR(255)  NULL,
  `chvSlotSelection`         VARCHAR(255)  NULL,
  `chvAddTo`                 VARCHAR(255)  NULL,
  `chvTemperatureControl`    VARCHAR(255)  NULL,
  `chvFilter`                VARCHAR(255)  NULL,
  `chvVibration`             VARCHAR(255)  NULL,
  `chvAlarm`                 VARCHAR(255)  NULL,
  `dtmCreateTime`            TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intMonitorscreenId`));
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_ElectroplatingRecord_mst` (
  `intElectroplatingRecordId` INT NOT NULL AUTO_INCREMENT,
  `intSlotNumber`             INT  NULL,
  `chvPartNo`                 VARCHAR(255)  NULL,
  `chvQuantity`               VARCHAR(255)  NULL,
  `chvASideCurrent`           VARCHAR(255)  NULL,
  `chvBSurfaceCurrent`        VARCHAR(255)  NULL,
  `dtmPlatingTime`            TIMESTAMP NULL ,
  `dtmEnteringTheTankTime`    TIMESTAMP NULL ,
  `dtmOutOfCylinderTime`      TIMESTAMP NULL ,
  `intAmpereHour`             INT NULL,
  `dtmCreateTime`             TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intElectroplatingRecordId`));
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_ProductionRecords_mst` (
  `intProductionRecordsId` INT NOT NULL AUTO_INCREMENT,
  `dtmProductionTime`      TIMESTAMP NULL,
  `chvPartNo`              VARCHAR(255)  NULL,
  `chvQuantity`            VARCHAR(255)  NULL,
  `dtmCreateTime`          TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intProductionRecordsId`));
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_PartNumberAreaAmmeter_mst` (
  `intPartNumberAreaAmmeterId` INT NOT NULL AUTO_INCREMENT,
  `chvItemName`                VARCHAR(255)  NULL,
  `chvA_Area`                  VARCHAR(255)  NULL,
  `chvB_Area`                  VARCHAR(255)  NULL,
  `chvLowCoefficient`          VARCHAR(255)  NULL,  
  `chvTinDensity`              VARCHAR(255)  NULL,    
  `chvCopperDensity`           VARCHAR(255)  NULL,  
  `chvTinTime`                 VARCHAR(255)  NULL,    
  `chvCopperHour`              VARCHAR(255)  NULL,     
  `chvA_TinHigh`               VARCHAR(255)  NULL,    
  `chvB_TinHigh`               VARCHAR(255)  NULL,    
  `chvA_TinLow`                VARCHAR(255)  NULL,  
  `chvB_TinLow`                VARCHAR(255)  NULL,  
  `chvA_CopperHigh`            VARCHAR(255)  NULL,  
  `chvB_CopperHigh`            VARCHAR(255)  NULL,
  `chvA_CopperLow`             VARCHAR(255)  NULL,      
  `chvB_CopperLow`             VARCHAR(255)  NULL,     
  `dtmCreateTime`              TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intPartNumberAreaAmmeterId`));
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_ItemNumberLibrary_mst` (
  `intItemNumberLibraryId` INT NOT NULL AUTO_INCREMENT,
  `chvItemName`            VARCHAR(255)  NULL,
  `intTinA_H`              INT  NULL,
  `intTinB_H`              INT  NULL, 
  `intTinA_L`              INT NULL,  
  `intTinB_L`              INT NULL,    
  `intTinningTime`         INT NULL,  
  `intCopperA_H`           INT NULL,    
  `intCopperB_H`           INT NULL,      
  `intCopperA_L`           INT NULL,      
  `intCopperB_L`           INT NULL,       
  `intCopperPlatingTime`   INT NULL,         
  `intSerialNumber`        INT NULL,    
  `dtmCreateTime`          TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intItemNumberLibraryId`));  
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_FaultTable_mst` (
  `intFaultTableId`  INT NOT NULL AUTO_INCREMENT,
  `chvFaultContent`  VARCHAR(255)  NULL,
  `chvSystemicState` VARCHAR(255)  NULL,  
  `chvOperator`      VARCHAR(255)  NULL,    
  `dtmCreateTime`    TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intFaultTableId`));    
  CREATE TABLE IF NOT EXISTS `useradmin`.`tbl_ErrorCode_mst` (
  `intErrorCodeId`  INT NOT NULL AUTO_INCREMENT,
  `chvCode`  		 VARCHAR(255)  NULL,
  `chvContent`       VARCHAR(255)  NULL,  
  `chvDealWith`      VARCHAR(500)  NULL,    
  `dtmCreateTime`    TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`intErrorCodeId`));   
REPLACE INTO  `useradmin`.`tbl_monitorscreen_mst`(`intSlotNumber`,`chvCraft`,`chvSlotSelection`,`chvAddTo`,`chvTemperatureControl`,`chvFilter`,`chvVibration`,`chvAlarm`,`dtmCreateTime`) VALUES
(1,'Loading',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(1   ,'Loading',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(2   ,'Up loading',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(3   ,'CW rinse 2',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(4   ,'CW rinse 1',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(5   ,'Back strip1',1,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(6   ,'Back strip 2',2,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(7   ,'CW rinse2',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(8   ,'CW rinse1',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(9   ,'Plating Tin1A',3,1,1,1,1,1,CURRENT_TIMESTAMP),
(10  ,'Plating Tin1B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(11  ,'Plating Tin2A',4,2,2,2,2,2,CURRENT_TIMESTAMP),
(12  ,'Plating Tin2B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(13  ,'Pre-Dip',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(14  ,'unoil',NULL,NULL,3,3,3,3,CURRENT_TIMESTAMP),
(15  ,'CW rinse2',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(16  ,'CW rinse1',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(17  ,'Micro etch',NULL,NULL,4,4,4,4,CURRENT_TIMESTAMP),
(18  ,'CW rinse 1',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(19  ,'CW rinse 2',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(20  ,'CW rinse 2',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(21  ,'CW rinse 1',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(22  ,'Pre-Dip',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(23  ,'CU 1A',5,3,5,5,5,5,CURRENT_TIMESTAMP),
(24  ,'CU 1B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(25  ,'CU 2A',6,4,6,6,6,6,CURRENT_TIMESTAMP),
(26  ,'CU 2B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(27  ,'CU 3A',7,5,7,7,7,7,CURRENT_TIMESTAMP),
(28  ,'CU 3B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(29  ,'CU 4A',8,6,8,8,8,8,CURRENT_TIMESTAMP),
(30  ,'CU 4B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(31  ,'CU 5A',9,7,9,9,9,9,CURRENT_TIMESTAMP),
(32  ,'CU 5B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(33  ,'CU 6A',10,8,10,10,10,10,CURRENT_TIMESTAMP),
(34  ,'CU 6B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(35  ,'CU 7A',11,9,11,11,11,11,CURRENT_TIMESTAMP),
(36  ,'CU 7B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP),
(37  ,'CU 8A',12,10,12,12,12,12,CURRENT_TIMESTAMP),
(38  ,'CU 8B',NULL,NULL,NULL,NULL,NULL,NULL,CURRENT_TIMESTAMP);
REPLACE INTO  `useradmin`.`tbl_ItemNumberLibrary_mst`(`chvItemName`,`intTinA_H`,`intTinB_H`, `intTinA_L`,`intTinB_L`,`intTinningTime`,`intCopperA_H`,`intCopperB_H`,`intCopperA_L`,`intCopperB_L`,`intCopperPlatingTime`,`intSerialNumber`,`dtmCreateTime`)VALUES
(01,0,10,0,10,999,0,10,0,10,999,2,CURRENT_TIMESTAMP),    
(10,10,0,10,0,999,10,0,10,0,999,3,CURRENT_TIMESTAMP),   
(11,10,10,10,10,999,10,10,10,10,999,4,CURRENT_TIMESTAMP),  
('ZD2842A',23.4,10.4,4.7,2,600,36,16,7.2,3.2,3600,1,CURRENT_TIMESTAMP);
  CREATE TABLE IF NOT EXISTS `useradmin`.`PLC_DM_AREA` (
  `PLC_DM_AREA_ID`  INT NOT NULL AUTO_INCREMENT,
  `0`  		 	 INT NULL,
  `1`  		 	 INT NULL, 
  `2`  		 	 INT NULL, 
  `3`  		 	 INT NULL, 
  `4`  		 	 INT NULL, 
  `5`  		 	 INT NULL, 
  `6`  		 	 INT NULL, 
  `7`  		 	 INT NULL, 
  `8`  		 	 INT NULL, 
  `9`  		 	 INT NULL, 
  `dtmCreateTime`    TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`PLC_DM_AREA_ID`));  
REPLACE INTO  `useradmin`.`PLC_DM_AREA`(`0`,`1`,`2`,`3`,`4`,`5`,`6`,`7`,`8`,`9`) VALUES
 (1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000)
,(1000,1000,1000,1000,1000,1000,1000,1000,1000,1000);

SELECT *FROM `useradmin`.`PLC_DM_AREA`;
DELETE FROM useradmin.tbl_PartNumberAreaAmmeter_mst  WHERE intPartNumberAreaAmmeterId =1;
SELECT *FROM useradmin.tbl_PartNumberAreaAmmeter_mst;
SELECT chvItemName,dtmCreateTime FROM useradmin.tbl_ItemNumberLibrary_mst;
UPDATE useradmin.tbl_PartNumberAreaAmmeter_mst SET chvA_Area =3213,chvB_Area =12,chvLowCoefficient =543,chvTinDensity =31,chvCopperDensity =24,chvTinTime =54,chvCopperHour =5,chvA_TinHigh =000.0,chvB_TinHigh =000.0,chvA_TinLow =000.0,chvB_TinLow =000.0,chvA_CopperHigh =000.0,chvB_CopperHigh =000.0,chvA_CopperLow =000.0,chvB_CopperLow =000.0,dtmCreateTime = CURRENT_TIMESTAMP Where intPartNumberAreaAmmeterId=1;
Select * from `useradmin`.`tbl_ItemNumberLibrary_mst`;
SELECT * FROM useradmin.tbl_PartNumberAreaAmmeter_mst
Select * from `useradmin`.`tbl_Monitorscreen_mst`