CREATE TABLE [dbo].[CollectionTable] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [Category]      VARCHAR (MAX) NULL,
    [Description]   VARCHAR (MAX) NULL,
    [Model]         VARCHAR (MAX) NULL,
    [WithThisActor] VARCHAR (MAX) NULL,
    [Price]         MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

