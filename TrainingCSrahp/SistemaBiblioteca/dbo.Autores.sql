﻿CREATE TABLE [dbo].[Autor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Descricao] VARCHAR(1000) NULL
)
