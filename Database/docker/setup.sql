/*

Enter custom T-SQL here that would run after SQL Server has started up. 

*/

CREATE DATABASE combi
COLLATE SQL_Latin1_General_CP1_CS_AS
GO

USE combi
GO

CREATE TABLE [dbo].[demo] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_demo] PRIMARY KEY CLUSTERED ([id] ASC)
);
GO

INSERT INTO [dbo].[demo] ([name])
VALUES 
(N'Piet Pienter'),
(N'Bert Bibber'),
(N'Susan'),
(N'Theo Flitser')
GO
