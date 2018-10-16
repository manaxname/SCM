CREATE TABLE [dbo].[Address]
(
	[Id]                  INT                   IDENTITY (1, 1) NOT NULL,
	[NumberOfBuildings]   SMALLINT              NOT NULL,
	[Zip]                 INT                   NOT NULL,
	[Street]              NVARCHAR(160)         NOT NULL,
	[City]                NVARCHAR(50)          NOT NULL,
	[District]            NVARCHAR(50)          NULL,
	[State]               NVARCHAR(50)          NULL,
	[Country]             NVARCHAR(30)          NOT NULL,
	CONSTRAINT [PK_Address]                     PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO


