CREATE PROCEDURE [dbo].[anul1]
AS
	SELECT Class9.Id, Class9.Name, Class9.Class, Class9.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5 
	FROM Class9
	JOIN Table2 ON Student_id = Class9.Id;
RETURN 0
