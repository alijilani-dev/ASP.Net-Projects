if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ENQUIRY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ENQUIRY]
GO

CREATE TABLE [dbo].[ENQUIRY] (
	[Enquiry_Id] [int] IDENTITY (1, 1) NOT NULL ,
	[Portal_ID] [int] NOT NULL ,
	[ContactName] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CompanyName] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Phone] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Email] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Comments] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TimeStamp] [datetime] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ENQUIRY] WITH NOCHECK ADD 
	CONSTRAINT [PK_ENQUIRY] PRIMARY KEY  CLUSTERED 
	(
		[Enquiry_Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ENQUIRY] WITH NOCHECK ADD 
	CONSTRAINT [DF_ENQUIRY_TimeStamp] DEFAULT (getdate()) FOR [TimeStamp]
GO

ALTER TABLE [dbo].[ENQUIRY] ADD 
	CONSTRAINT [FK_ENQUIRY_PORTAL] FOREIGN KEY 
	(
		[Portal_ID]
	) REFERENCES [dbo].[PORTAL] (
		[portal_id]
	)
GO

