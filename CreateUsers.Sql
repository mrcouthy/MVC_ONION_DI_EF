CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY(1,1) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NULL,
    [Phone]     NVARCHAR (50) NULL,
    [UserId]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) 
);
