CREATE TABLE [dbo].[User]
(
	[Id]            INT             NOT NULL        PRIMARY KEY,
	[Name]          NVarchar(50)    NOT NULL,
	[Surname]       NVARCHAR(50)    NOT NULL,
	[Patronymic]    NVARCHAR(50)    NULL,
	[Birthday]      Date            NULL,
	[Email]         NVarchar(50)    NULL,
	[Phone]         NVarchar(20)    NUll
);
GO
