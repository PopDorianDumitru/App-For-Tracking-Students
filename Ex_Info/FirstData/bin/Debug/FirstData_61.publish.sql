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
/*
The column [dbo].[Table2].[student_id] is being dropped, data loss could occur.
*/

IF EXISTS (select top 1 1 from [dbo].[Table2])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering Table [dbo].[Table2]...';


GO
ALTER TABLE [dbo].[Table2] DROP COLUMN [student_id];


GO
PRINT N'Altering Procedure [dbo].[inserare]...';


GO
ALTER PROCEDURE [dbo].[inserare]
	@id int,
	@name text,
	@age int,
	@an int,
	@not1 int,
	@not2 int,
	@not3 int,
	@not4 int,
	@not5 int
AS
	INSERT INTO Table1(Name, Age, Class) VALUES(@name, @age, @an);
	INSERT INTO Table2(not1,not2,not3,not4,not5) VALUES(@not1,@not2,@not3,@not4,@not5);
RETURN 0
GO
PRINT N'Altering Procedure [dbo].[stergere]...';


GO
ALTER PROCEDURE [dbo].[stergere]
	@id int
AS
	DELETE FROM Table1 WHERE id= @id;
	DELETE FROM Table2 WHERE id = @id;
RETURN 0
GO
PRINT N'Refreshing Procedure [dbo].[medie]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[medie]';


GO
PRINT N'Update complete.';


GO
