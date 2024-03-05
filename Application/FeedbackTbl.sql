-- Script Date: 05/03/2024 3:48 pm  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [FeedbackTbl] (
  [F_Id] INTEGER NOT NULL
, [Feedback] TEXT NOT NULL
, [C_Id] INTEGER NOT NULL
, [Contact] TEXT NOT NULL
, CONSTRAINT [PK_FeedbackTbl] PRIMARY KEY ([F_Id])
);
