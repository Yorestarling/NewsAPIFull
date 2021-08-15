CREATE TABLE [dbo].[Authors] (
    [AuthorId]   INT          IDENTITY (1, 1) NOT NULL,
    [UsersId]    INT          NOT NULL,
    [AuthorName] VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_AuthorId] PRIMARY KEY CLUSTERED ([AuthorId] ASC),
    CONSTRAINT [FK_UserId] FOREIGN KEY ([UsersId]) REFERENCES [dbo].[UsersLog] ([UserId])
);

