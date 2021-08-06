CREATE PROCEDURE [dbo].[inserare]
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
	INSERT INTO Table2( Student_id ,not1,not2,not3,not4,not5) VALUES(SCOPE_IDENTITY() ,@not1,@not2,@not3,@not4,@not5);
RETURN 0
