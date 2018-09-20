CREATE TABLE [dbo].[UserAddress]
(
	[Id]              INT       NOT NULL        PRIMARY KEY,
	[UserId]          INT       NOT NULL,
	[AddressId]       INT       NOT NULL,
	CONSTRAINT [FK_UserAddress_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
	CONSTRAINT [FK_UserAddress_Address] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([Id]),
);
GO
