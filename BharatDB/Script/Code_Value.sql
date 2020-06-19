﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


----------------CODE ID
IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 1)
BEGIN
 INSERT INTO CODE_ID VALUES(1, 'HUSBAND WIFE TYPE CODE ID')
END

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 2)
BEGIN
 INSERT INTO CODE_ID VALUES(2, 'Expenses Table Name code Value')
END

IF NOT EXISTS(SELECT 1 FROM CODE_ID WHERE CODE_ID = 3)
BEGIN
 INSERT INTO CODE_ID VALUES(3, 'Expenses Type Value')
END

------------------CODE VALUE
--Code Id 1
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 1 AND CODE_VALUE = 'HUSB')
BEGIN
 INSERT INTO CODE_VALUE VALUES(1, 'HUSB', 'HUSBAND CODE ID', NULL,NULL)
END

IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 1 AND CODE_VALUE = 'WIFE')
BEGIN
 INSERT INTO CODE_VALUE VALUES(1, 'WIFE', 'WIFE CODE ID', NULL,NULL)
END


-- Code id 2
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 2 AND CODE_VALUE = 'HUWF')
BEGIN
 INSERT INTO CODE_VALUE VALUES(2, 'HUWF', 'Husband Wife Table', NULL,NULL)
END

IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 2 AND CODE_VALUE = 'EXPN')
BEGIN
 INSERT INTO CODE_VALUE VALUES(2, 'EXPN', 'Expenses Table', NULL,NULL)
END

-- Code 3
IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 3 AND CODE_VALUE = 'INCM')
BEGIN
 INSERT INTO CODE_VALUE VALUES(3, 'INCM', 'Incoming', NULL,NULL)
END

IF NOT EXISTS(SELECT 1 FROM CODE_VALUE WHERE CODE_ID = 3 AND CODE_VALUE = 'OUTG')
BEGIN
 INSERT INTO CODE_VALUE VALUES(3, 'OUTG', 'Outgoing', NULL,NULL)
END
