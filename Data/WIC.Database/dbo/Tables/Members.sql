CREATE TABLE [dbo].[Members] (
    [Id]      UNIQUEIDENTIFIER NOT NULL,
    [Name]    VARCHAR (35)     NULL,
    [Address] VARCHAR (35)     NULL,
    [City]    VARCHAR (35)     NULL,
    [State]   VARCHAR (35)     NULL,
    [ZIP]     VARCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

