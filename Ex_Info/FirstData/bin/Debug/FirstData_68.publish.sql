﻿/*
Deployment script for EX_INFO

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "EX_INFO"
:setvar DefaultFilePrefix "EX_INFO"
:setvar DefaultDataPath "C:\Users\40732\AppData\Local\Microsoft\VisualStudio\SSDT\"
:setvar DefaultLogPath "C:\Users\40732\AppData\Local\Microsoft\VisualStudio\SSDT\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Altering Procedure [dbo].[ordNume]...';


GO
ALTER PROCEDURE [dbo].[ordNume]
	@cls int = 0
AS	
	IF @cls = 1
	BEGIN
		SELECT Class9.Id, Class9.Name, 
		Class9.Class, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Class9 JOIN Table2 
		ON Student_id = dbo.Class9.Id 
		ORDER BY Name
	END
	ELSE
	IF @cls = 2
	BEGIN
		SELECT Clasa10.Id, Clasa10.Name, 
		Clasa10.Class, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Clasa10 JOIN Table2 
		ON Student_id = dbo.Clasa10.Id 
		ORDER BY Name
	END
	ELSE
	IF @cls = 3
	BEGIN
		SELECT Class11.Id, Class11.Name, 
		Class11.Class, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Class11 JOIN Table2 
		ON Student_id = dbo.Class11.Id 
		ORDER BY Name
	END
	ELSE
	IF @cls = 4
	BEGIN
		SELECT Class12.Id, Class12.Name, 
		Class12.Class, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Class12 JOIN Table2 
		ON Student_id = dbo.Class12.Id 
		ORDER BY Name
	END
	ELSE
	BEGIN 
		SELECT Table1.Id, Table1.Name, 
		Table1.Class, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Table1 JOIN Table2 
		ON Student_id = dbo.Table1.Id 
		ORDER BY Name
	END
RETURN 0
GO
PRINT N'Update complete.';


GO
