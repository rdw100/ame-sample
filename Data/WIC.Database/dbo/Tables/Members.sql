CREATE TABLE [dbo].[Members] (
    [MemberId]  INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (35) NULL,
    [LastName]  VARCHAR (35) NULL,
    [Address]   VARCHAR (35) NULL,
    [City]      VARCHAR (35) NULL,
    [State]     VARCHAR (35) NULL,
    [ZIP]       VARCHAR (10) NULL,
    CONSTRAINT [PK_MEMBER] PRIMARY KEY CLUSTERED ([MemberId] ASC)
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [PrimaryKey]
    ON [dbo].[Members]([MemberId] ASC);

