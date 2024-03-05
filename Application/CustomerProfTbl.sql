-- Script Date: 05/03/2024 12:17 pm  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [CustomerProfTbl] (
  [Id] INTEGER NOT NULL
, [Name] TEXT NOT NULL
, [Gender] TEXT NOT NULL
, [City] TEXT NOT NULL
, [Contact] TEXT NOT NULL
, [Email] TEXT NOT NULL
, CONSTRAINT [PK_CustomerProfTbl] PRIMARY KEY ([Id])
);
