CREATE TABLE [dbo].[Product]
(
	[Code]          INT             IDENTITY (1, 1) NOT NULL,
	[Name]          NVarchar(250)   NOT NULL,
	[Description]   NVARCHAR(MAX)   NULL,
	[IsOnSale]      BIT             DEFAULT ((0)) NOT NULL
);
GO