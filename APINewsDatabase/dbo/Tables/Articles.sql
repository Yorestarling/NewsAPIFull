CREATE TABLE [dbo].[Articles] (
    [ArticleId]    INT            IDENTITY (1, 1) NOT NULL,
    [AuthorId]     INT            NOT NULL,
    [Title]        NVARCHAR (255) NOT NULL,
    [descriptions] NVARCHAR (MAX) NULL,
    [ulr]          NVARCHAR (MAX) NULL,
    [ulrToImage]   NVARCHAR (MAX) NULL,
    [PublishedAt]  DATETIME       NULL,
    [Content]      NVARCHAR (MAX) NULL,
    [SourcesId]    INT            NOT NULL,
    [CategoryId]   INT            NOT NULL,
    [CountriesId]  INT            NOT NULL,
    CONSTRAINT [PK_ArticleId] PRIMARY KEY CLUSTERED ([ArticleId] ASC),
    CONSTRAINT [FK_AuthorIds] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Authors] ([AuthorId]),
    CONSTRAINT [FK_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId]),
    CONSTRAINT [FK_CountriesId] FOREIGN KEY ([CountriesId]) REFERENCES [dbo].[Countries] ([CountriesId]),
    CONSTRAINT [FK_SourcesIds] FOREIGN KEY ([SourcesId]) REFERENCES [dbo].[Sources] ([SourcesId])
);

