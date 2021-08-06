CREATE PROCEDURE [dbo].[anul2]

AS
	SELECT Clasa10.Id, Clasa10.Name, Clasa10.Class, Clasa10.Age
	,Table2.not1, Table2.not2 , Table2.not3, Table2.not4, Table2.not5 
	FROM Clasa10
	JOIN Table2 ON Student_id = Clasa10.Id;
RETURN 0
