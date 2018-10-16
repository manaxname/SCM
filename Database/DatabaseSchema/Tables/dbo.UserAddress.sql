CREATE TABLE [dbo].[UserAddress]
(
	[Id]                              INT       IDENTITY (1, 1) NOT NULL,
	[UserId]                          INT       NOT NULL,
	[AddressId]                       INT       NOT NULL,
	CONSTRAINT [PK_UserAddress]                 PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_UserAddress_User]            FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
	CONSTRAINT [FK_UserAddress_Address]         FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([Id]),
);
GO
