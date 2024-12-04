IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'trade')
	DROP DATABASE [trade]
GO

CREATE DATABASE [trade]  ON (NAME = N'trade_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\Data\trade_Data.mdf' , SIZE = 2, FILEGROWTH = 10%) LOG ON (NAME = N'trade_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\Data\trade_log.ldf' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO

exec sp_dboption N'trade', N'autoclose', N'false'
GO

exec sp_dboption N'trade', N'bulkcopy', N'false'
GO

exec sp_dboption N'trade', N'trunc. log', N'false'
GO

exec sp_dboption N'trade', N'torn page detection', N'true'
GO

exec sp_dboption N'trade', N'read only', N'false'
GO

exec sp_dboption N'trade', N'dbo use', N'false'
GO

exec sp_dboption N'trade', N'single', N'false'
GO

exec sp_dboption N'trade', N'autoshrink', N'false'
GO

exec sp_dboption N'trade', N'ANSI null default', N'false'
GO

exec sp_dboption N'trade', N'recursive triggers', N'false'
GO

exec sp_dboption N'trade', N'ANSI nulls', N'false'
GO

exec sp_dboption N'trade', N'concat null yields null', N'false'
GO

exec sp_dboption N'trade', N'cursor close on commit', N'false'
GO

exec sp_dboption N'trade', N'default to local cursor', N'false'
GO

exec sp_dboption N'trade', N'quoted identifier', N'false'
GO

exec sp_dboption N'trade', N'ANSI warnings', N'false'
GO

exec sp_dboption N'trade', N'auto create statistics', N'true'
GO

exec sp_dboption N'trade', N'auto update statistics', N'true'
GO

use [trade]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ADVERTISE__adver__286302EC]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ADVERTISEMENT] DROP CONSTRAINT FK__ADVERTISE__adver__286302EC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MEMBERS__country__1FCDBCEB]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MEMBERS] DROP CONSTRAINT FK__MEMBERS__country__1FCDBCEB
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MAIN_LINK__porta__1ED998B2]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MAIN_LINKS] DROP CONSTRAINT FK__MAIN_LINK__porta__1ED998B2
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MEMBERS__portal___20C1E124]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MEMBERS] DROP CONSTRAINT FK__MEMBERS__portal___20C1E124
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRADING_C__porta__21B6055D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRADING_CATEGORY] DROP CONSTRAINT FK__TRADING_C__porta__21B6055D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MODULES__main_li__267ABA7A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MODULES] DROP CONSTRAINT FK__MODULES__main_li__267ABA7A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__SUB_LINKS__main___25869641]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[SUB_LINKS] DROP CONSTRAINT FK__SUB_LINKS__main___25869641
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ADVERTISE__membe__29572725]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ADVERTISEMENT] DROP CONSTRAINT FK__ADVERTISE__membe__29572725
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CAREERS__member___2D27B809]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CAREERS] DROP CONSTRAINT FK__CAREERS__member___2D27B809
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOGINS_AU__membe__22AA2996]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOGINS_AUDIT_TRAIL] DROP CONSTRAINT FK__LOGINS_AU__membe__22AA2996
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MEMBER_CA__membe__239E4DCF]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MEMBER_CATEGORY] DROP CONSTRAINT FK__MEMBER_CA__membe__239E4DCF
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MEMBER_CA__tradi__24927208]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MEMBER_CATEGORY] DROP CONSTRAINT FK__MEMBER_CA__tradi__24927208
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRADING_F__tradi__34C8D9D1]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRADING_FLOOR] DROP CONSTRAINT FK__TRADING_F__tradi__34C8D9D1
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MODULES__sub_lin__276EDEB3]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MODULES] DROP CONSTRAINT FK__MODULES__sub_lin__276EDEB3
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ADVERTISE__modul__2A4B4B5E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ADVERTISEMENT] DROP CONSTRAINT FK__ADVERTISE__modul__2A4B4B5E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ANNOUNCEM__modul__2B3F6F97]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ANNOUNCEMENTS] DROP CONSTRAINT FK__ANNOUNCEM__modul__2B3F6F97
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__AUDIT_TRA__modul__2C3393D0]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[AUDIT_TRAIL] DROP CONSTRAINT FK__AUDIT_TRA__modul__2C3393D0
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CAREERS__module___2E1BDC42]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CAREERS] DROP CONSTRAINT FK__CAREERS__module___2E1BDC42
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONTACT_D__modul__2F10007B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONTACT_DETAILS] DROP CONSTRAINT FK__CONTACT_D__modul__2F10007B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONTENT__module___300424B4]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONTENT] DROP CONSTRAINT FK__CONTENT__module___300424B4
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__EXTERNAL___modul__30F848ED]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[EXTERNAL_WEB_SERVICES] DROP CONSTRAINT FK__EXTERNAL___modul__30F848ED
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PRESS_REL__modul__31EC6D26]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESS_RELEASE] DROP CONSTRAINT FK__PRESS_REL__modul__31EC6D26
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PRODUCTS__module__32E0915F]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRODUCTS] DROP CONSTRAINT FK__PRODUCTS__module__32E0915F
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRADING_F__modul__33D4B598]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRADING_FLOOR] DROP CONSTRAINT FK__TRADING_F__modul__33D4B598
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__USEFUL_LI__modul__35BCFE0A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[USEFUL_LINKS] DROP CONSTRAINT FK__USEFUL_LI__modul__35BCFE0A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ADVERTISEMENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ANNOUNCEMENTS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AUDIT_TRAIL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAREERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CAREERS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONTACT_DETAILS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONTENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONTENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EXTERNAL_WEB_SERVICES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRESS_RELEASE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRODUCTS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRODUCTS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRADING_FLOOR]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[USEFUL_LINKS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MODULES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MODULES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOGINS_AUDIT_TRAIL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEMBER_CATEGORY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEMBER_CATEGORY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SUB_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SUB_LINKS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MAIN_LINKS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEMBERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEMBERS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRADING_CATEGORY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ADVERTISEMENT_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[COUNTRY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[COUNTRY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MASTER_ACCOUNT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PORTAL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PORTAL]
GO

if not exists (select * from master.dbo.syslogins where loginname = N'dc90\ASPNET')
	exec sp_grantlogin N'dc90\ASPNET'
	exec sp_defaultdb N'dc90\ASPNET', N'master'
	exec sp_defaultlanguage N'dc90\ASPNET', N'us_english'
GO

if not exists (select * from master.dbo.syslogins where loginname = N'dewqms')
BEGIN
	declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'master', @loginlang = N'us_english'
	if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
		select @logindb = N'master'
	if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
		select @loginlang = @@language
	exec sp_addlogin N'dewqms', null, @logindb, @loginlang
END
GO

if not exists (select * from master.dbo.syslogins where loginname = N'Duwamish7_login')
BEGIN
	declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'Duwamish7vb', @loginlang = N'us_english'
	if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
		select @logindb = N'master'
	if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
		select @loginlang = @@language
	exec sp_addlogin N'Duwamish7_login', null, @logindb, @loginlang
END
GO

exec sp_addsrvrolemember N'dewqms', sysadmin
GO

CREATE TABLE [dbo].[ADVERTISEMENT_TYPE] (
	[advert_type_id] [int] IDENTITY (1, 1) NOT NULL ,
	[advert_type] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[COUNTRY] (
	[country_id] [int] IDENTITY (1, 1) NOT NULL ,
	[country_short_code] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[country_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MASTER_ACCOUNT] (
	[username] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[password] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PORTAL] (
	[portal_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_logo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_stylesheet] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MAIN_LINKS] (
	[main_links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_id] [int] NULL ,
	[link_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[link_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[link_open_type] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MEMBERS] (
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[portal_id] [int] NULL ,
	[password] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[member_company] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[manufacturer_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[exp_imp_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[dealer_reseller_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[retailer_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[service_prov_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[freight_type] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[mailing_address] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_phone] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_fax] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_website] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact1_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact1_mobile] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact1_email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact2_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact2_mobile] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[company_contact2_email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[country_id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TRADING_CATEGORY] (
	[trading_cat_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_id] [int] NULL ,
	[trading_cat_desc] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOGINS_AUDIT_TRAIL] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MEMBER_CATEGORY] (
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[trading_cat_id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SUB_LINKS] (
	[sub_links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[main_links_id] [int] NULL ,
	[sub_link_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[sub_link_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[sub_link_open_type] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MODULES] (
	[module_id] [int] IDENTITY (1, 1) NOT NULL ,
	[main_links_id] [int] NULL ,
	[sub_links_id] [int] NULL ,
	[module_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[module_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[module_priority] [int] NULL ,
	[module_position] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[show_flag] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ADVERTISEMENT] (
	[advert_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_image_url] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_alt_text] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_priority] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[advert_type_id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ANNOUNCEMENTS] (
	[ann_id] [int] IDENTITY (1, 1) NOT NULL ,
	[ann_text] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[module_id] [int] NULL ,
	[show_flag] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AUDIT_TRAIL] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[timestamp] [datetime] NULL ,
	[module_id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CAREERS] (
	[careers_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[career_text] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONTACT_DETAILS] (
	[contact_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[contact_text] [varchar] (300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONTENT] (
	[content_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[content_image_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[content_text] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EXTERNAL_WEB_SERVICES] (
	[external_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[external_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRESS_RELEASE] (
	[press_release_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[press_release_image] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[press_release_text] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRODUCTS] (
	[product_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[product_name] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[product_short_image_url] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[product_short_desc] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[product_big_image_url] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[product_desc] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[product_web_url] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TRADING_FLOOR] (
	[post_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[post_heading] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[post_desc] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[trading_cat_id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[USEFUL_LINKS] (
	[links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[links_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[links_short_desc] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[links_image_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKADVERTISEMENT_TYPE] ON [dbo].[ADVERTISEMENT_TYPE]([advert_type_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKCOUNTRY] ON [dbo].[COUNTRY]([country_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKMASTER_ACCOUNT] ON [dbo].[MASTER_ACCOUNT]([username]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKPORTAL] ON [dbo].[PORTAL]([portal_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKMAIN_LINKS] ON [dbo].[MAIN_LINKS]([main_links_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKMEMBERS] ON [dbo].[MEMBERS]([member_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKTRADING_CATEGORY] ON [dbo].[TRADING_CATEGORY]([trading_cat_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKLOGINS_AUDIT_TRAIL] ON [dbo].[LOGINS_AUDIT_TRAIL]([id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKSUB_LINKS] ON [dbo].[SUB_LINKS]([sub_links_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKMODULES] ON [dbo].[MODULES]([module_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKADVERTISEMENT] ON [dbo].[ADVERTISEMENT]([advert_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKANNOUNCEMENTS] ON [dbo].[ANNOUNCEMENTS]([ann_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKAUDIT_TRAIL] ON [dbo].[AUDIT_TRAIL]([id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKCAREERS] ON [dbo].[CAREERS]([careers_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKCONTACT_DETAILS] ON [dbo].[CONTACT_DETAILS]([contact_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKCONTENT] ON [dbo].[CONTENT]([content_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKEXTERNAL_WEB_SERVICES] ON [dbo].[EXTERNAL_WEB_SERVICES]([external_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKPRESS_RELEASE] ON [dbo].[PRESS_RELEASE]([press_release_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKPRODUCTS] ON [dbo].[PRODUCTS]([product_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKTRADING_FLOOR] ON [dbo].[TRADING_FLOOR]([post_id]) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [XPKUSEFUL_LINKS] ON [dbo].[USEFUL_LINKS]([links_id]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ADVERTISEMENT_TYPE] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[advert_type_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[COUNTRY] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[country_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MASTER_ACCOUNT] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[username]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PORTAL] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[portal_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MAIN_LINKS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[main_links_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MEMBERS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[member_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TRADING_CATEGORY] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[trading_cat_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOGINS_AUDIT_TRAIL] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SUB_LINKS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[sub_links_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MODULES] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[module_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ADVERTISEMENT] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[advert_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ANNOUNCEMENTS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[ann_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AUDIT_TRAIL] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CAREERS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[careers_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONTACT_DETAILS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[contact_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONTENT] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[content_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[EXTERNAL_WEB_SERVICES] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[external_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRESS_RELEASE] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[press_release_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRODUCTS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[product_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TRADING_FLOOR] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[post_id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[USEFUL_LINKS] WITH NOCHECK ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[links_id]
	)  ON [PRIMARY] 
GO

 CREATE  INDEX [XIF1MAIN_LINKS] ON [dbo].[MAIN_LINKS]([portal_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1MEMBERS] ON [dbo].[MEMBERS]([portal_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2MEMBERS] ON [dbo].[MEMBERS]([country_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1TRADING_CATEGORY] ON [dbo].[TRADING_CATEGORY]([portal_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1LOGINS_AUDIT_TRAIL] ON [dbo].[LOGINS_AUDIT_TRAIL]([member_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1MEMBER_CATEGORY] ON [dbo].[MEMBER_CATEGORY]([member_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2MEMBER_CATEGORY] ON [dbo].[MEMBER_CATEGORY]([trading_cat_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1SUB_LINKS] ON [dbo].[SUB_LINKS]([main_links_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1MODULES] ON [dbo].[MODULES]([main_links_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2MODULES] ON [dbo].[MODULES]([sub_links_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1ADVERTISEMENT] ON [dbo].[ADVERTISEMENT]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2ADVERTISEMENT] ON [dbo].[ADVERTISEMENT]([member_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF3ADVERTISEMENT] ON [dbo].[ADVERTISEMENT]([advert_type_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1ANNOUNCEMENTS] ON [dbo].[ANNOUNCEMENTS]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1AUDIT_TRAIL] ON [dbo].[AUDIT_TRAIL]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1CAREERS] ON [dbo].[CAREERS]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2CAREERS] ON [dbo].[CAREERS]([member_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1CONTACT_DETAILS] ON [dbo].[CONTACT_DETAILS]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1CONTENT] ON [dbo].[CONTENT]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1EXTERNAL_WEB_SERVICES] ON [dbo].[EXTERNAL_WEB_SERVICES]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1PRESS_RELEASE] ON [dbo].[PRESS_RELEASE]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1PRODUCTS] ON [dbo].[PRODUCTS]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1TRADING_FLOOR] ON [dbo].[TRADING_FLOOR]([module_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF2TRADING_FLOOR] ON [dbo].[TRADING_FLOOR]([trading_cat_id]) ON [PRIMARY]
GO

 CREATE  INDEX [XIF1USEFUL_LINKS] ON [dbo].[USEFUL_LINKS]([module_id]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MAIN_LINKS] ADD 
	 FOREIGN KEY 
	(
		[portal_id]
	) REFERENCES [dbo].[PORTAL] (
		[portal_id]
	)
GO

ALTER TABLE [dbo].[MEMBERS] ADD 
	 FOREIGN KEY 
	(
		[country_id]
	) REFERENCES [dbo].[COUNTRY] (
		[country_id]
	),
	 FOREIGN KEY 
	(
		[portal_id]
	) REFERENCES [dbo].[PORTAL] (
		[portal_id]
	)
GO

ALTER TABLE [dbo].[TRADING_CATEGORY] ADD 
	 FOREIGN KEY 
	(
		[portal_id]
	) REFERENCES [dbo].[PORTAL] (
		[portal_id]
	)
GO

ALTER TABLE [dbo].[LOGINS_AUDIT_TRAIL] ADD 
	 FOREIGN KEY 
	(
		[member_id]
	) REFERENCES [dbo].[MEMBERS] (
		[member_id]
	)
GO

ALTER TABLE [dbo].[MEMBER_CATEGORY] ADD 
	 FOREIGN KEY 
	(
		[member_id]
	) REFERENCES [dbo].[MEMBERS] (
		[member_id]
	),
	 FOREIGN KEY 
	(
		[trading_cat_id]
	) REFERENCES [dbo].[TRADING_CATEGORY] (
		[trading_cat_id]
	)
GO

ALTER TABLE [dbo].[SUB_LINKS] ADD 
	 FOREIGN KEY 
	(
		[main_links_id]
	) REFERENCES [dbo].[MAIN_LINKS] (
		[main_links_id]
	)
GO

ALTER TABLE [dbo].[MODULES] ADD 
	 FOREIGN KEY 
	(
		[main_links_id]
	) REFERENCES [dbo].[MAIN_LINKS] (
		[main_links_id]
	),
	 FOREIGN KEY 
	(
		[sub_links_id]
	) REFERENCES [dbo].[SUB_LINKS] (
		[sub_links_id]
	)
GO

ALTER TABLE [dbo].[ADVERTISEMENT] ADD 
	 FOREIGN KEY 
	(
		[advert_type_id]
	) REFERENCES [dbo].[ADVERTISEMENT_TYPE] (
		[advert_type_id]
	),
	 FOREIGN KEY 
	(
		[member_id]
	) REFERENCES [dbo].[MEMBERS] (
		[member_id]
	),
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[ANNOUNCEMENTS] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[AUDIT_TRAIL] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[CAREERS] ADD 
	 FOREIGN KEY 
	(
		[member_id]
	) REFERENCES [dbo].[MEMBERS] (
		[member_id]
	),
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[CONTACT_DETAILS] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[CONTENT] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[EXTERNAL_WEB_SERVICES] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[PRESS_RELEASE] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[PRODUCTS] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

ALTER TABLE [dbo].[TRADING_FLOOR] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	),
	 FOREIGN KEY 
	(
		[trading_cat_id]
	) REFERENCES [dbo].[TRADING_CATEGORY] (
		[trading_cat_id]
	)
GO

ALTER TABLE [dbo].[USEFUL_LINKS] ADD 
	 FOREIGN KEY 
	(
		[module_id]
	) REFERENCES [dbo].[MODULES] (
		[module_id]
	)
GO

