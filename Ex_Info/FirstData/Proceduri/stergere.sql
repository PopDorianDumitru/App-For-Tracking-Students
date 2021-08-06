CREATE PROCEDURE [dbo].[stergere]
	@id int
AS
	DELETE FROM Table2 WHERE Student_id = @id;
	DELETE FROM Table1 WHERE id= @id;
	
RETURN 0
