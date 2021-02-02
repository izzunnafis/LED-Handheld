CREATE TABLE [dbo].[SignUpTable] (
    [Id]       INT           NOT NULL IDENTITY,
    [username] VARCHAR(50) NULL,
    [password] VARCHAR(50) NULL,
    [email]    VARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

