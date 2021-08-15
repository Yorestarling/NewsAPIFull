CREATE TABLE [dbo].[UsersLog] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [DisplayName] VARCHAR (250) NOT NULL,
    [Username]    VARCHAR (40)  NOT NULL,
    [Passwords]   VARCHAR (400) NOT NULL,
    CONSTRAINT [PK_UserId] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

