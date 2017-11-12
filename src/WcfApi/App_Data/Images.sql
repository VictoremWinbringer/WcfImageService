CREATE TABLE [dbo].[Images]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY , 
    [Title] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(255) NULL, 
    [Data] IMAGE NOT NULL
);
