CREATE PROCEDURE [dbo].[medie]
AS
	SELECT Table1.Id, Table1.Name, Table1.Class, Table1.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5
	FROM Table1 JOIN Table2 ON Student_id = Table1.Id 
	ORDER BY CONVERT(DOUBLE PRECISION, (not1+not2+not3+not4+not5)/5.0);
RETURN 0
