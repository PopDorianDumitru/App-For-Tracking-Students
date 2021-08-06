CREATE PROCEDURE [dbo].[cautNume]
	@Nume nvarchar(50)
AS
	SELECT Table1.Id, Table1.Name, Table1.Class, Table1.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5 
	FROM dbo.Table1
	JOIN Table2 ON Student_id = Table1.Id
	WHERE Name LIKE '%'+@Nume+'%';
RETURN 0
