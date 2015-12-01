CREATE TABLE [dbo].[Traject]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TrajectName] NCHAR(100) NOT NULL, 
    [JamDateTime] DATETIME NULL
)

GO

CREATE UNIQUE INDEX [IX_Traject_ID] ON [dbo].[Traject] ([Column])
