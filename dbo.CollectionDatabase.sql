CREATE TABLE [dbo].[CollectionDatabase] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [Category]      VARCHAR (MAX) NULL,
    [Description]   VARCHAR (MAX) NULL,
    [Model]         VARCHAR (MAX) NULL,
    [WithThisActor] NVARCHAR(MAX) NULL,
    [Price] MONEY NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

