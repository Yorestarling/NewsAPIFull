CREATE TABLE [dbo].[Sources] (
    [SourcesId]   INT          IDENTITY (1, 1) NOT NULL,
    [SourcesName] VARCHAR (30) NOT NULL,
    CONSTRAINT [PK_SourcesId] PRIMARY KEY CLUSTERED ([SourcesId] ASC)
);

