CREATE PROCEDURE [dbo].[ordNume]
	@cls int = 0
AS	
	IF @cls = 1
	BEGIN
		SELECT Class9.Id, Class9.Name,  
		Class9.Class,Class9.Age, Table2.not1,Table2.not2,
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
		Clasa10.Class, Clasa10.Age,  Table2.not1,Table2.not2,
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
		Class11.Class,Class11.Age, Table2.not1,Table2.not2,
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
		Class12.Class, Class12.Age,Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Class12 JOIN Table2 
		ON Student_id = dbo.Class12.Id 
		ORDER BY Name
	END
	ELSE
	BEGIN 
		SELECT Table1.Id, Table1.Name,  
		Table1.Class,Table1.Age, Table2.not1,Table2.not2,
		Table2.not3
		,Table2.not4,Table2.not5 
		FROM dbo.Table1 JOIN Table2 
		ON Student_id = dbo.Table1.Id 
		ORDER BY Name
	END
RETURN 0
