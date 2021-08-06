CREATE PROCEDURE [dbo].[anul4]
AS
	SELECT Class12.Id, Class12.Name, Class12.Class, Class12.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5 
	FROM Class12
	JOIN Table2 ON Student_id = Class12.Id;
RETURN 0
