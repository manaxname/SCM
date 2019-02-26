CREATE TABLE [dbo].[Product]
(
	[Code]          INT                    IDENTITY (1, 1) NOT NULL,
	[Name]          NVarchar(250)          NOT NULL,
	[Description]   NVARCHAR(MAX)          NULL,
	[Status]        VARCHAR(15)            NOT NULL,
	[CategoryId]    INT                    NOT NULL,

	CONSTRAINT [PK_Product]                PRIMARY KEY CLUSTERED ([Code] ASC),
	CONSTRAINT [FK_Product_Category]       FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id])
);
GO