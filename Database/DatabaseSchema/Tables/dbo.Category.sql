CREATE TABLE [dbo].[Category]
(
	[Id]                 INT              IDENTITY (1, 1) NOT NULL,
	[Name]               NVARCHAR(60)     NOT NULL,
	[ParentCategoryId]   INT              NULL,

	CONSTRAINT [PK_Category]              PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Category_Parent]       FOREIGN KEY ([ParentCategoryId]) REFERENCES [dbo].[Category] ([Id])
)
