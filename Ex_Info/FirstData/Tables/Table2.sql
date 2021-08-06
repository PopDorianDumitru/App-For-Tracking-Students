CREATE TABLE [dbo].[Table2]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Student_id] INT NOT NULL,
    [not1] INT NULL, 
    [not2] INT NULL, 
    [not3] INT NULL, 
    [not4] INT NULL, 
    [not5] INT NULL, 
    CONSTRAINT [student_id] FOREIGN KEY ([Student_id]) REFERENCES [Table1]([Id]), 
 
)
