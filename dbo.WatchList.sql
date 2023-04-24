CREATE TABLE [dbo].[WatchList]
(
	[id] INT IDENTITY(1,1) PRIMARY KEY, 
    [userId] INT FOREIGN KEY REFERENCES [User](id) NOT NULL, 
    series INT INDEX IX_WatchList_Series NOT NULL
)
