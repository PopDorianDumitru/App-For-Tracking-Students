CREATE PROCEDURE [dbo].[anul3]
AS
	SELECT Class11.Id, Class11.Name, Class11.Class, Class11.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5 
	FROM Class11
	JOIN Table2 ON Student_id = Class11.Id;
RETURN 0
