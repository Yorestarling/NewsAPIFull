CREATE TABLE [dbo].[Categories] (
    [CategoryId]   INT          IDENTITY (1, 1) NOT NULL,
    [CategoryName] VARCHAR (30) NOT NULL,
    CONSTRAINT [PK_CategoryId] PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

