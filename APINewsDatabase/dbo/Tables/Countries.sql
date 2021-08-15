CREATE TABLE [dbo].[Countries] (
    [CountriesId]  INT          IDENTITY (1, 1) NOT NULL,
    [ContriesName] VARCHAR (70) NOT NULL,
    CONSTRAINT [PK_CountriesId] PRIMARY KEY CLUSTERED ([CountriesId] ASC)
);

