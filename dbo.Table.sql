CREATE TABLE [dbo].[UserInfo]
(
	[email] VARCHAR(MAX) NOT NULL primary key, 
    [firstName] VARCHAR(MAX) NOT NULL, 
    [lastName] VARCHAR(MAX) NOT NULL, 
    [password] VARCHAR(MAX) NOT NULL, 
    [birthday] DATE NULL,
)
