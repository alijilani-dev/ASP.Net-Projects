---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- List of Database Dependancies. Ali Akbar Thursday, 24th March 2005.
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

--	VoucherMaster
--	VoucherDetails
--	AgentAccountDetails
--	TransactionDetails
--	AgentMaster
--	VoucherMaster
--	BankExchangeRateList
--	CountryList
--	CurrencyList

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- Create Table VoucherMaster.
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
CREATE TABLE [VoucherMaster] (
	[ID] [int] IDENTITY (6, 1) NOT NULL ,
	[VoucherNumber] [decimal](18, 0) NULL ,
	[VoucherDate] [smalldatetime] NULL ,
	[ValueDate] [smalldatetime] NULL ,
	[Narration] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	CONSTRAINT [PK_VoucherMaster] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- Create Table VoucherDetails.
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
CREATE TABLE [VoucherDetails] (
	[DetailID] [int] IDENTITY (10, 1) NOT NULL ,
	[AgentAccountID] [uniqueidentifier] NOT NULL ,
	[MasterID] [int] NOT NULL ,
	[FC_Debit] [decimal](18, 6) NULL ,
	[LC_Debit] [decimal](18, 6) NULL ,
	[FC_Credit] [decimal](18, 6) NULL ,
	[LC_Credit] [decimal](18, 6) NULL ,
	[Rate] [decimal](18, 6) NULL ,
	[Principal_Commision] [char] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	CONSTRAINT [PK_VoucherDetails] PRIMARY KEY  CLUSTERED 
	(
		[DetailID]
	)  ON [PRIMARY] ,
	CONSTRAINT [FK_VoucherDetails_VoucherMaster] FOREIGN KEY 
	(
		[MasterID]
	) REFERENCES [VoucherMaster] (
		[ID]
	) NOT FOR REPLICATION 
) ON [PRIMARY]
GO
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- Create Table .
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- Create Table AgentAccountDetails.
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
CREATE TABLE [AgentAccountDetails] (
	[Id] [uniqueidentifier] NOT NULL CONSTRAINT [DF_AgentAccountDetails_Id] DEFAULT (newid()),
	[VoucherNumber] [decimal](18, 0) IDENTITY (15, 1) NOT NULL ,
	[CreditDateTime] [datetime] NULL ,
	[DebitDateTime] [datetime] NULL ,
	[AgentAccountId] [uniqueidentifier] NULL ,
	[TransactionId] [uniqueidentifier] NULL ,
	[CreditLC] [decimal](18, 6) NOT NULL CONSTRAINT [DF_AgentAccountDetails_CreditLC] DEFAULT (0),
	[CreditUSD] [decimal](18, 2) NOT NULL CONSTRAINT [DF_AgentAccountDetails_CreditUSD] DEFAULT (0),
	[DebitLC] [decimal](18, 6) NOT NULL CONSTRAINT [DF_AgentAccountDetails_DebitLC] DEFAULT (0),
	[DebitUSD] [decimal](18, 2) NOT NULL CONSTRAINT [DF_AgentAccountDetails_DebitUSD] DEFAULT (0),
	CONSTRAINT [PK_AgentAccountDetails] PRIMARY KEY  CLUSTERED 
	(
		[Id]
	) WITH  FILLFACTOR = 90  ON [PRIMARY] ,
	CONSTRAINT [FK_AgentAccountDetails_AgentMaster] FOREIGN KEY 
	(
		[AgentAccountId]
	) REFERENCES [AgentMaster] (
		[Id]
	),
	CONSTRAINT [FK_AgentAccountDetails_TransactionDetails] FOREIGN KEY 
	(
		[TransactionId]
	) REFERENCES [TransactionDetails] (
		[Id]
	)
) ON [PRIMARY]
GO
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------
-- .
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

