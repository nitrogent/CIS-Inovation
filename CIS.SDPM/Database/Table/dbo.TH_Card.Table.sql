USE [TBP_CIS_SDPM]
GO

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.TH_Card
	(
		ID int NOT NULL IDENTITY (1, 1),
		ProjectID int NOT NULL,
		ProjectTitle varchar(255) NOT NULL,
		SprintID int NOT NULL,
		SprintTitle varchar(255) NOT NULL,
		CardID int NOT NULL,
		CardCode varchar(255) NOT NULL,
		CardTitle varchar(255) NOT NULL,
		CreatedBy varchar(255) NOT NULL,
		CreatedOn datetime NOT NULL,
		LastUpdatedBy varchar(255) NULL,
		LastUpdatedOn datetime NULL,
		RowStatus smallint NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TH_Card ADD CONSTRAINT
	PK_TH_Card PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TH_Card SET (LOCK_ESCALATION = TABLE)
GO
COMMIT