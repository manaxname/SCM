CREATE TABLE [dbo].[Product]
(
	[Code]          INT             IDENTITY (1, 1) NOT NULL,
	[Name]          NVarchar(250)   NOT NULL,
	[Description]   NVARCHAR(MAX)   NULL,
	[Status]        VARCHAR(15)     NOT NULL
);
GO