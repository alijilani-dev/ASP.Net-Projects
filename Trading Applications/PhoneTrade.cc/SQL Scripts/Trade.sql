/****** Object:  Stored Procedure dbo.USP_Check_DuplicateUserName    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Check_DuplicateUserName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Check_DuplicateUserName]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ADVERTISEMENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_ADVERTISEMENT]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_ADVERTISEMENT_TYPE]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_ANNOUNCEMENTS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CAREERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_CAREERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_CAREERS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_CONTACT_DETAILS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CONTENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_CONTENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_CONTENT]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_COUNTRY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_COUNTRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_COUNTRY]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_EXTERNAL_WEB_SERVICES]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_LOGINS_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MAIN_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MAIN_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MASTER_ACCOUNT]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MEMBERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MEMBERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MEMBERS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MEMBER_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MEMBER_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MEMBER_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MOBILEREVIEW    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MOBILEREVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MOBILEREVIEW]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MODULES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_MODULES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_MODULES]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PORTAL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_PORTAL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_PORTAL]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PRESS_RELEASE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_PRESS_RELEASE]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PRODUCTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_PRODUCTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_PRODUCTS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_SUB_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_SUB_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_SUB_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_TRADING_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_TRADING_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_TRADING_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_Testimonial    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_Testimonial]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_Testimonial]
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_USEFUL_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_DELETE_USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_DELETE_USEFUL_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_GET_BrandMOBILEMODEL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_BrandMOBILEMODEL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_BrandMOBILEMODEL]
GO

/****** Object:  Stored Procedure dbo.USP_GET_MOBILEREVIEW    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_MOBILEREVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_MOBILEREVIEW]
GO

/****** Object:  Stored Procedure dbo.USP_GET_MOBILESECRET    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_MOBILESECRET]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_MOBILESECRET]
GO

/****** Object:  Stored Procedure dbo.USP_GET_NewMEMBERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_NewMEMBERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_NewMEMBERS]
GO

/****** Object:  Stored Procedure dbo.USP_GET_TESTIMONIALS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_TESTIMONIALS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_TESTIMONIALS]
GO

/****** Object:  Stored Procedure dbo.USP_GET_TRADE_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_GET_TRADE_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_GET_TRADE_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Advertisements    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Advertisements]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Advertisements]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Announcements    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Announcements]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Announcements]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Careers    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Careers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Careers]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Contact_Details    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Contact_Details]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Contact_Details]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Contents    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Contents]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Contents]
GO

/****** Object:  Stored Procedure dbo.USP_Get_MainLinks_Modules    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_MainLinks_Modules]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_MainLinks_Modules]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Portal_Main_Links    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Portal_Main_Links]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Portal_Main_Links]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Portal_Main_Sub_Links    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Portal_Main_Sub_Links]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Portal_Main_Sub_Links]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Press_Releases    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Press_Releases]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Press_Releases]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Products    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Products]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Products]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Top_Announcements    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Top_Announcements]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Top_Announcements]
GO

/****** Object:  Stored Procedure dbo.USP_Get_TradingFloors    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_TradingFloors]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_TradingFloors]
GO

/****** Object:  Stored Procedure dbo.USP_Get_Usefullinks    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Usefullinks]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Usefullinks]
GO

/****** Object:  Stored Procedure dbo.USP_Get_ValidMember    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_ValidMember]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_ValidMember]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ADVERTISEMENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_ADVERTISEMENT]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_ADVERTISEMENT_TYPE]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_ANNOUNCEMENTS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CAREERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_CAREERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_CAREERS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_CONTACT_DETAILS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CONTENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_CONTENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_CONTENT]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_COUNTRY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_COUNTRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_COUNTRY]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ENQUIRY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_ENQUIRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_ENQUIRY]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_EXTERNAL_WEB_SERVICES]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_LOGINS_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MAIN_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MAIN_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MASTER_ACCOUNT]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MEMBERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MEMBERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MEMBERS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MEMBER_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MEMBER_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MEMBER_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MOBILEREVIEW    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MOBILEREVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MOBILEREVIEW]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MODULES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_MODULES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_MODULES]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PORTAL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_PORTAL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_PORTAL]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PRESS_RELEASE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_PRESS_RELEASE]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PRODUCTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_PRODUCTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_PRODUCTS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_SUB_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_SUB_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_SUB_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADE_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_TRADE_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_TRADE_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_TRADING_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADING_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_TRADING_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_Testimonial    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_Testimonial]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_Testimonial]
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_USEFUL_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_USEFUL_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ADVERTISEMENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_ADVERTISEMENT]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_ADVERTISEMENT_TYPE]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_ANNOUNCEMENTS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CAREERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_CAREERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_CAREERS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_CONTACT_DETAILS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CONTENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_CONTENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_CONTENT]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_COUNTRY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_COUNTRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_COUNTRY]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CURRENCY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_CURRENCY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_CURRENCY]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_EXTERNAL_WEB_SERVICES]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_LOGINS_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_LatestMobiles    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_LatestMobiles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_LatestMobiles]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MAIN_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MAIN_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MASTER_ACCOUNT]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MEMBERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MEMBERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MEMBERS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MEMBERS_Trading_Cat    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MEMBERS_Trading_Cat]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MEMBERS_Trading_Cat]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MMANUFACTURER    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MMANUFACTURER]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MMANUFACTURER]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MMOBILEMODEL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MMOBILEMODEL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MMOBILEMODEL]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MOBILEREVIEW    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MOBILEREVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MOBILEREVIEW]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MOBILESECRET    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MOBILESECRET]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MOBILESECRET]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MODULES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_MODULES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_MODULES]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PORTAL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_PORTAL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_PORTAL]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PRESS_RELEASE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_PRESS_RELEASE]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PRODUCTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_PRODUCTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_PRODUCTS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_SUB_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_SUB_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_SUB_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TESTIMONIALS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_TESTIMONIALS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_TESTIMONIALS]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADE_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_TRADE_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_TRADE_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_TRADING_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADING_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_TRADING_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_USEFUL_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_SELECT_USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_SELECT_USEFUL_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ADVERTISEMENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_ADVERTISEMENT]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_ADVERTISEMENT_TYPE]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_ANNOUNCEMENTS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CAREERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_CAREERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_CAREERS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_CONTACT_DETAILS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CONTENT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_CONTENT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_CONTENT]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_COUNTRY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_COUNTRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_COUNTRY]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_EXTERNAL_WEB_SERVICES]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_LOGINS_AUDIT_TRAIL]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MAIN_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_MAIN_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_MASTER_ACCOUNT]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MEMBERS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_MEMBERS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_MEMBERS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MOBILEREVIEW    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_MOBILEREVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_MOBILEREVIEW]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MODULES    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_MODULES]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_MODULES]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_Module_Links    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_Module_Links]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_Module_Links]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PORTAL    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_PORTAL]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_PORTAL]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PRESS_RELEASE    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_PRESS_RELEASE]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PRODUCTS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_PRODUCTS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_PRODUCTS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_SUB_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_SUB_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_SUB_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADE_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_TRADE_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_TRADE_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_TRADING_CATEGORY]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADING_FLOOR    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_TRADING_FLOOR]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_Testimonial    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_Testimonial]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_Testimonial]
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_USEFUL_LINKS    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_UPDATE_USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_UPDATE_USEFUL_LINKS]
GO

/****** Object:  Stored Procedure dbo.USP_Valid_MasterAccount    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Valid_MasterAccount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Valid_MasterAccount]
GO

/****** Object:  Table [dbo].[ADVERTISEMENT]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ADVERTISEMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ADVERTISEMENT]
GO

/****** Object:  Table [dbo].[ADVERTISEMENT_TYPE]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ADVERTISEMENT_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ADVERTISEMENT_TYPE]
GO

/****** Object:  Table [dbo].[ANNOUNCEMENTS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ANNOUNCEMENTS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ANNOUNCEMENTS]
GO

/****** Object:  Table [dbo].[AUDIT_TRAIL]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AUDIT_TRAIL]
GO

/****** Object:  Table [dbo].[CAREERS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAREERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CAREERS]
GO

/****** Object:  Table [dbo].[CONTACT_DETAILS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONTACT_DETAILS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONTACT_DETAILS]
GO

/****** Object:  Table [dbo].[CONTENT]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONTENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONTENT]
GO

/****** Object:  Table [dbo].[COUNTRY]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[COUNTRY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[COUNTRY]
GO

/****** Object:  Table [dbo].[Currency]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Currency]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Currency]
GO

/****** Object:  Table [dbo].[ENQUIRY]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ENQUIRY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ENQUIRY]
GO

/****** Object:  Table [dbo].[EXTERNAL_WEB_SERVICES]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EXTERNAL_WEB_SERVICES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EXTERNAL_WEB_SERVICES]
GO

/****** Object:  Table [dbo].[LOGINS_AUDIT_TRAIL]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOGINS_AUDIT_TRAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOGINS_AUDIT_TRAIL]
GO

/****** Object:  Table [dbo].[MAIN_LINKS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MAIN_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MAIN_LINKS]
GO

/****** Object:  Table [dbo].[MASTER_ACCOUNT]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MASTER_ACCOUNT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MASTER_ACCOUNT]
GO

/****** Object:  Table [dbo].[MEMBERS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEMBERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEMBERS]
GO

/****** Object:  Table [dbo].[MEMBER_CATEGORY]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MEMBER_CATEGORY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MEMBER_CATEGORY]
GO

/****** Object:  Table [dbo].[MODULES]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MODULES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MODULES]
GO

/****** Object:  Table [dbo].[MODULE_LINKS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MODULE_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MODULE_LINKS]
GO

/****** Object:  Table [dbo].[MobileReview]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MobileReview]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MobileReview]
GO

/****** Object:  Table [dbo].[MobileSecret]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MobileSecret]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MobileSecret]
GO

/****** Object:  Table [dbo].[PORTAL]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PORTAL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PORTAL]
GO

/****** Object:  Table [dbo].[PRESS_RELEASE]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRESS_RELEASE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRESS_RELEASE]
GO

/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRODUCTS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRODUCTS]
GO

/****** Object:  Table [dbo].[SUB_LINKS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SUB_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SUB_LINKS]
GO

/****** Object:  Table [dbo].[TESTIMONIALS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TESTIMONIALS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TESTIMONIALS]
GO

/****** Object:  Table [dbo].[TRADING_CATEGORY]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRADING_CATEGORY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRADING_CATEGORY]
GO

/****** Object:  Table [dbo].[TRADING_FLOOR]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRADING_FLOOR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRADING_FLOOR]
GO

/****** Object:  Table [dbo].[Trade_Floor]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Trade_Floor]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Trade_Floor]
GO

/****** Object:  Table [dbo].[USEFUL_LINKS]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USEFUL_LINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[USEFUL_LINKS]
GO

/****** Object:  Table [dbo].[mControl]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mControl]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mControl]
GO

/****** Object:  Table [dbo].[mDispType]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mDispType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mDispType]
GO

/****** Object:  Table [dbo].[mLatestMobiles]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mLatestMobiles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mLatestMobiles]
GO

/****** Object:  Table [dbo].[mManufacturer]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mManufacturer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mManufacturer]
GO

/****** Object:  Table [dbo].[mMobileModel]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mMobileModel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mMobileModel]
GO

/****** Object:  Table [dbo].[mNetwork]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mNetwork]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mNetwork]
GO

/****** Object:  Table [dbo].[mRingtone]    Script Date: 12/14/2005 1:42:19 PM ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mRingtone]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[mRingtone]
GO

/****** Object:  Table [dbo].[ADVERTISEMENT]    Script Date: 12/14/2005 1:42:22 PM ******/
CREATE TABLE [dbo].[ADVERTISEMENT] (
	[advert_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_image_url] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_alt_text] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[advert_priority] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[advert_type_id] [int] NULL ,
	[ad_Position] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ADVERTISEMENT_TYPE]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[ADVERTISEMENT_TYPE] (
	[advert_type_id] [int] IDENTITY (1, 1) NOT NULL ,
	[advert_type] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ANNOUNCEMENTS]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[ANNOUNCEMENTS] (
	[ann_id] [int] IDENTITY (1, 1) NOT NULL ,
	[ann_text] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[module_id] [int] NULL ,
	[show_flag] [int] NULL ,
	[ann_TextLink_Url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ann_Heading] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AUDIT_TRAIL]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[AUDIT_TRAIL] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[timestamp] [datetime] NULL ,
	[module_id] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[CAREERS]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[CAREERS] (
	[careers_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[career_text] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[CONTACT_DETAILS]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[CONTACT_DETAILS] (
	[contact_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[contact_text] [varchar] (300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[CONTENT]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[CONTENT] (
	[content_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[Portal_ID] [int] NULL ,
	[content_image_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[content_text_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[COUNTRY]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[COUNTRY] (
	[country_id] [int] IDENTITY (1, 1) NOT NULL ,
	[country_short_code] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[country_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[country_flag_Img_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Currency]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[Currency] (
	[Currency_Code] [int] NULL ,
	[Currency_Symbol] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ENQUIRY]    Script Date: 12/14/2005 1:42:23 PM ******/
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

/****** Object:  Table [dbo].[EXTERNAL_WEB_SERVICES]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[EXTERNAL_WEB_SERVICES] (
	[external_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[external_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[LOGINS_AUDIT_TRAIL]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[LOGINS_AUDIT_TRAIL] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MAIN_LINKS]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[MAIN_LINKS] (
	[main_links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_id] [int] NULL ,
	[link_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[link_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[link_open_type] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[show_flag] [int] NULL ,
	[Img_url] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Img_url_MouseOver] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Row_Position] [int] NULL ,
	[Redirect_Main_Link_ID] [int] NULL ,
	[Links_Seq] [smallint] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MASTER_ACCOUNT]    Script Date: 12/14/2005 1:42:23 PM ******/
CREATE TABLE [dbo].[MASTER_ACCOUNT] (
	[username] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[password] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MEMBERS]    Script Date: 12/14/2005 1:42:24 PM ******/
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
	[country_id] [int] NULL ,
	[Company_Logo_Url] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MEMBER_CATEGORY]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[MEMBER_CATEGORY] (
	[member_id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[trading_cat_id] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MODULES]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[MODULES] (
	[module_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[module_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[module_priority] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MODULE_LINKS]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[MODULE_LINKS] (
	[Module_Links_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[main_links_id] [int] NULL ,
	[sub_links_id] [int] NULL ,
	[Module_Position] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Show_flag] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MobileReview]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[MobileReview] (
	[MR_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[MobileSrNo] [numeric](18, 0) NULL ,
	[MobileReview] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PortalID] [int] NULL ,
	[Status] [int] NULL ,
	[timeStamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MobileSecret]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[MobileSecret] (
	[MS_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[MobileSrNo] [numeric](18, 0) NULL ,
	[MobileSecret] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PortalID] [int] NULL ,
	[Status] [int] NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PORTAL]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[PORTAL] (
	[portal_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_logo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_stylesheet] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_img_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[portal_img_over_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Portal_Home_Img_Url] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Portal_Home_Text] [varchar] (2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PRESS_RELEASE]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[PRESS_RELEASE] (
	[press_release_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[press_release_image] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[press_release_text] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[press_release_detail] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Show_Flag] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 12/14/2005 1:42:24 PM ******/
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

/****** Object:  Table [dbo].[SUB_LINKS]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[SUB_LINKS] (
	[sub_links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[main_links_id] [int] NULL ,
	[sub_link_name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[sub_link_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[sub_link_open_type] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[show_flag] [int] NULL ,
	[Img_url] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Img_url_MouseOver] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TESTIMONIALS]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[TESTIMONIALS] (
	[TID] [int] IDENTITY (1, 1) NOT NULL ,
	[Portal_ID] [int] NULL ,
	[Member_ID] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Text] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TimeStamp] [datetime] NULL ,
	[Show_Flag] [int] NOT NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TRADING_CATEGORY]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[TRADING_CATEGORY] (
	[trading_cat_id] [int] IDENTITY (1, 1) NOT NULL ,
	[portal_id] [int] NULL ,
	[trading_cat_desc] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TRADING_FLOOR]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[TRADING_FLOOR] (
	[post_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[post_heading] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[post_desc] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL ,
	[trading_cat_id] [int] NULL ,
	[Member_Id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Trade_Floor]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[Trade_Floor] (
	[Trading_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[post_heading] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Trade_Type] [int] NULL ,
	[Member_Id] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MobileSrNo] [numeric](18, 0) NOT NULL ,
	[ModelNo] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ManufCode] [numeric](18, 0) NULL ,
	[Quantity] [int] NOT NULL ,
	[Price] [money] NULL ,
	[CurrencyCode] [int] NULL ,
	[Spec] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Warranty] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ProviderLogo] [bit] NULL ,
	[Packaging] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RequestDate] [datetime] NULL ,
	[ShippingTerms] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Location] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[post_desc] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Status] [smallint] NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[USEFUL_LINKS]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[USEFUL_LINKS] (
	[links_id] [int] IDENTITY (1, 1) NOT NULL ,
	[module_id] [int] NULL ,
	[links_url] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[links_short_desc] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[links_image_url] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timestamp] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mControl]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[mControl] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[AdLogin] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[AdPwd] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mDispType]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[mDispType] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[DispTypeCode] [numeric](18, 0) NOT NULL ,
	[DispType] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mLatestMobiles]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[mLatestMobiles] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[LatestMobiles] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mManufacturer]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[mManufacturer] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[ManufCode] [numeric](18, 0) NOT NULL ,
	[ManufName] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Logo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ActDate] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mMobileModel]    Script Date: 12/14/2005 1:42:24 PM ******/
CREATE TABLE [dbo].[mMobileModel] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[ModelNo] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[ManufCode] [numeric](18, 0) NULL ,
	[AdditionalInfo] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NetworkTypeCode] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Announced] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Status] [numeric](18, 0) NULL ,
	[Weight] [numeric](18, 0) NULL ,
	[Dimension] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PhoneBook] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CallRecords] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DispTypeCode] [numeric](18, 0) NULL ,
	[DisplayInfo] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DispSize] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RingtoneTypeCode] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CustomizeTone] [bit] NULL ,
	[Vibration] [bit] NULL ,
	[BatteryInfo] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OSType] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[GPRS] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DataSpeed] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SMS] [bit] NULL ,
	[MMS] [bit] NULL ,
	[EmailMsg] [bit] NULL ,
	[InstantMsg] [bit] NULL ,
	[Clock] [bit] NULL ,
	[Alarm] [bit] NULL ,
	[InfraRed] [bit] NULL ,
	[BlueTooth] [bit] NULL ,
	[Model3G] [bit] NULL ,
	[Games] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MobileColor] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Camera] [bit] NULL ,
	[CameraInfo] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Features] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ImgFile1] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ImgFile2] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ImgFile3] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ImgFile4] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ImgFile5] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Descriptions] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mNetwork]    Script Date: 12/14/2005 1:42:25 PM ******/
CREATE TABLE [dbo].[mNetwork] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[NetworkTypeCode] [numeric](18, 0) NOT NULL ,
	[NetworkType] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[mRingtone]    Script Date: 12/14/2005 1:42:25 PM ******/
CREATE TABLE [dbo].[mRingtone] (
	[SrNo] [numeric](18, 0) NOT NULL ,
	[RingtoneTypeCode] [numeric](18, 0) NOT NULL ,
	[RingtoneType] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_Check_DuplicateUserName    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_Check_DuplicateUserName 
@UserName VARCHAR(20)
AS

SELECT TOP 1 'A' FROM Members 
WHERE Member_ID = @UserName



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ADVERTISEMENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_ADVERTISEMENT]
(
	@advert_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [ADVERTISEMENT]
	WHERE
		[advert_id] = @advert_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_ADVERTISEMENT_TYPE]
(
	@advert_type_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [ADVERTISEMENT_TYPE]
	WHERE
		[advert_type_id] = @advert_type_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_ANNOUNCEMENTS]
(
	@ann_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [ANNOUNCEMENTS]
	WHERE
		[ann_id] = @ann_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_AUDIT_TRAIL]
(
	@id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [AUDIT_TRAIL]
	WHERE
		[id] = @id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CAREERS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_CAREERS]
(
	@careers_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [CAREERS]
	WHERE
		[careers_id] = @careers_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_CONTACT_DETAILS]
(
	@contact_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [CONTACT_DETAILS]
	WHERE
		[contact_id] = @contact_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_CONTENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_CONTENT]
(
	@content_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [CONTENT]
	WHERE
		[content_id] = @content_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_COUNTRY    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_COUNTRY]
(
	@country_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [COUNTRY]
	WHERE
		[country_id] = @country_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_EXTERNAL_WEB_SERVICES]
(
	@external_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [EXTERNAL_WEB_SERVICES]
	WHERE
		[external_id] = @external_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_LOGINS_AUDIT_TRAIL]
(
	@id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [LOGINS_AUDIT_TRAIL]
	WHERE
		[id] = @id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MAIN_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_MAIN_LINKS]
(
	@main_links_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [MAIN_LINKS]
	WHERE
		[main_links_id] = @main_links_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_MASTER_ACCOUNT]
(
	@username varchar(50)
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [MASTER_ACCOUNT]
	WHERE
		[username] = @username
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MEMBERS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_MEMBERS]
(
	@member_id varchar(20)
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [MEMBERS]
	WHERE
		[member_id] = @member_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MEMBER_CATEGORY    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_DELETE_MEMBER_CATEGORY
@Member_ID VARCHAR(20)
AS

DELETE FROM Member_Category WHERE member_id = @Member_ID



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MOBILEREVIEW    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_DELETE_MOBILEREVIEW]
(
	@MR_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [MOBILEREVIEW]
	WHERE
		[MR_id] = @MR_id
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_MODULES    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_MODULES]
(
	@module_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [MODULES]
	WHERE
		[module_id] = @module_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PORTAL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_PORTAL]
(
	@portal_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [PORTAL]
	WHERE
		[portal_id] = @portal_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PRESS_RELEASE    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_PRESS_RELEASE]
(
	@press_release_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [PRESS_RELEASE]
	WHERE
		[press_release_id] = @press_release_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_PRODUCTS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_PRODUCTS]
(
	@product_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [PRODUCTS]
	WHERE
		[product_id] = @product_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_SUB_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_SUB_LINKS]
(
	@sub_links_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [SUB_LINKS]
	WHERE
		[sub_links_id] = @sub_links_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_TRADING_CATEGORY]
(
	@trading_cat_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [TRADING_CATEGORY]
	WHERE
		[trading_cat_id] = @trading_cat_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_TRADING_FLOOR    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_TRADING_FLOOR]
(
	@post_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [TRADING_FLOOR]
	WHERE
		[post_id] = @post_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_Testimonial    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_DELETE_Testimonial 
(
@TID	int
)
AS
BEGIN 
	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [Testimonials]
	WHERE
		[TID] = @TID
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_DELETE_USEFUL_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_DELETE_USEFUL_LINKS]
(
	@links_id int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [USEFUL_LINKS]
	WHERE
		[links_id] = @links_id
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_GET_BrandMOBILEMODEL    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_GET_BrandMOBILEMODEL 
@ManufCode numeric = null
AS


IF @ManufCode is null
	SELECT [SrNo], [ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Status], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 
	FROM [mMobileModel]
else
	SELECT [SrNo], [ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Status], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 
	FROM [mMobileModel]
WHERE ManufCode = @ManufCode


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_GET_MOBILEREVIEW    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_GET_MOBILEREVIEW]
(
	@MR_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @MR_id IS NULL BEGIN
	
	SELECT 
		MOBILEREVIEW.MR_id,
		MOBILEREVIEW.MobileSrNo,
		MOBILEREVIEW.MobileReview,
		MOBILEREVIEW.PortalID,
		MOBILEREVIEW.Status AS ReviewStatus,
		MOBILEREVIEW.[timeStamp],
		mManufacturer.ManufName,
		mManufacturer.Logo,
		mMobileModel.*

	FROM 
	[MOBILEReview] 
		INNER JOIN
		mMobileModel
			ON MOBILEREVIEW.MobileSrNo = mMobileModel.SrNo
		INNER JOIN
			mManufacturer
			ON mMobileModel.ManufCode = mManufacturer.ManufCode
	END

	ELSE BEGIN

	SELECT 
		MOBILEREVIEW.MR_id,
		MOBILEREVIEW.MobileSrNo,
		MOBILEREVIEW.MobileReview,
		MOBILEREVIEW.PortalID,
		MOBILEREVIEW.Status AS ReviewStatus,
		MOBILEREVIEW.[timeStamp],
		mManufacturer.ManufName,
		mManufacturer.Logo,
		mMobileModel.*
	FROM 
	[MOBILEREVIEW] 
		INNER JOIN
		mMobileModel
			ON MOBILEREVIEW.MobileSrNo = mMobileModel.SrNo
		INNER JOIN
		mManufacturer
			ON mMobileModel.ManufCode = mManufacturer.ManufCode
	WHERE
		[MR_id] = @MR_id


END
	
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_GET_MOBILESECRET    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_GET_MOBILESECRET]
(
	@MS_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @MS_id IS NULL BEGIN
	
	SELECT 
		MOBILESECRET.MS_id,
		MOBILESECRET.MobileSrNo,
		MOBILESECRET.MobileSecret,
		MOBILESECRET.PortalID,
		MOBILESECRET.Status AS SecretStatus,
		MOBILESECRET.[timeStamp],
		mMobileModel.*
	FROM 
	[MOBILESECRET] 
		INNER JOIN
		mMobileModel
			ON MOBILESECRET.MobileSrNo = mMobileModel.SrNo
	END

	ELSE BEGIN

	SELECT 
		MOBILESECRET.MS_id,
		MOBILESECRET.MobileSrNo,
		MOBILESECRET.MobileSecret,
		MOBILESECRET.PortalID,
		MOBILESECRET.Status AS SecretStatus,
		MOBILESECRET.[timeStamp],
		mMobileModel.*
	FROM 
	[MOBILESECRET] 
		INNER JOIN
		mMobileModel
			ON MOBILESECRET.MobileSrNo = mMobileModel.SrNo
	WHERE
		[MS_id] = @MS_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_GET_NewMEMBERS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_GET_NewMEMBERS]
(
	@Portal_ID INT = 0 ,
	@Days INT = 365
)
AS
BEGIN
	IF @Portal_ID =0
		BEGIN
			SELECT 
				member_id,
				portal_id,
				password,
				member_company,
				manufacturer_type,
				exp_imp_type,
				dealer_reseller_type,
				retailer_type,
				service_prov_type,
				freight_type,
				mailing_address,
				company_phone,
				company_fax,
				company_email,
				company_website,
				company_contact1_name,
				company_contact1_mobile,
				company_contact1_email,
				company_contact2_name,
				company_contact2_mobile,
				company_contact2_email,
				company_Logo_Url,
				country.*
			FROM 
			[MEMBERS] 
				INNER JOIN Country
					ON [MEMBERS].Country_ID = Country.Country_ID
			WHERE 
				dateDiff(day,MEMBERS.[TimeStamp] , getDAte())<= @Days
			Order by member_company
		END
	ELSE	
		BEGIN
			SELECT 
				member_id,
				portal_id,
				password,
				member_company,
				manufacturer_type,
				exp_imp_type,
				dealer_reseller_type,
				retailer_type,
				service_prov_type,
				freight_type,
				mailing_address,
				company_phone,
				company_fax,
				company_email,
				company_website,
				company_contact1_name,
				company_contact1_mobile,
				company_contact1_email,
				company_contact2_name,
				company_contact2_mobile,
				company_contact2_email,
				company_Logo_Url,
				country.*
			FROM 
			[MEMBERS] 
				INNER JOIN Country
					ON [MEMBERS].Country_ID = Country.Country_ID
			WHERE
				MEMBERS.portal_id = @portal_id
				AND dateDiff(day,MEMBERS.[TimeStamp] , getDAte()) <= @Days
			Order by member_company
		END		
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_GET_TESTIMONIALS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_GET_TESTIMONIALS
@Portal_ID INT,
@Member_ID VARCHAR(20) = NULL
AS
IF @Member_ID IS NULL
	BEGIN
		SELECT 
			Testimonials.TID,
			Testimonials.[Text] AS TText,
			Testimonials.[TimeStamp] AS TestimonialDateTime,
			Testimonials.Show_Flag,
			Members.*
		FROM Testimonials
		INNER JOIN Members
			ON Testimonials.member_id= Members.member_id
		WHERE 
			Testimonials.Portal_Id = @Portal_ID
	END
ELSE
	BEGIN
		SELECT 
			Testimonials.TID,
			Testimonials.[Text] AS TText,
			Testimonials.[TimeStamp] AS TestimonialDateTime,
			Testimonials.Show_Flag,
			Members.*
		FROM Testimonials
		INNER JOIN Members
			ON Testimonials.member_id= Members.member_id
		WHERE 
			Testimonials.Portal_Id = @Portal_ID
			AND Testimonials.member_id= @Member_ID
	END








GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_GET_TRADE_FLOOR    Script Date: 12/14/2005 1:42:25 PM ******/




-- USP_GET_TRADE_FLOOR 1
-- USP_GET_TRADE_FLOOR 1,'',1

CREATE PROCEDURE USP_GET_TRADE_FLOOR
@Portal_ID INT,
@Member_ID VARCHAR(20) = '',
@HotOffer BIT = 0,
@Condition VARCHAR(3000) = ''
 
AS

DECLARE @WHERE VARCHAR(500)
DECLARE @OrderBy VARCHAR(500)
DECLARE @SELECT VARCHAR(4000)
DECLARE @DetailCondition VARCHAR(500)

SET @SELECT = 	' 
			mManufacturer.ManufName AS Brand,
			(CASE WHEN  Trade_Floor.MobileSrNo = 0 OR Trade_Floor.MobileSrNo IS 
			NULL THEN Trade_Floor.ModelNo ELSE mMobileModel.ModelNo END) AS 
			MODELNo,
			Trade_Floor.Quantity, 
			(
			CASE 
			WHEN ISNULL(Trade_Floor.Price,0) <=0 THEN
				''ASK For Details''
			ELSE
				CAST(Trade_Floor.Price AS VARCHAR) + Currency.Currency_Symbol 
			END)	AS Price, 
			(CASE WHEN Trade_Floor.Status = 0 THEN ''NEW'' ELSE '''' END) AS Status,
			Trade_Floor.Spec, 			
			Trade_Floor.Trading_ID,
			Trade_Floor.post_heading,
			Trade_Floor.Country_Name as CountryName,
			Trade_Floor.Country_flag_Img_url as CountryFlagImgUrl, 
			Trade_Floor.Location,
			Trade_Floor.Trade_Type, 
			Trade_Floor.Member_Id, 
			Trade_Floor.MobileSrNo,  
			Trade_Floor.ManufCode, 
			Trade_Floor.CurrencyCode, 
			Trade_Floor.Warranty, 
			Trade_Floor.ProviderLogo, 
			(CASE WHEN ISNULL(Trade_Floor.Packaging,'''')='''' THEN 
			''ASK For Details'' 
			ELSE 
			Trade_Floor.Packaging
			END) AS Packaging,
			Trade_Floor.RequestDate, 
			Trade_Floor.ShippingTerms,
			(CASE WHEN ISNULL(Trade_Floor.Location,'''')='''' THEN 
			''ASK For Details'' 
			ELSE 
			Trade_Floor.Location 
			END) AS Location, 
			(CASE WHEN ISNULL(Trade_Floor.post_desc,'''')='''' THEN 
			''No Comments.'' 
			ELSE 
			Trade_Floor.post_desc
			END) AS post_desc,
			mManufacturer.Logo,
			Members.company_email,
			Members.company_phone,
			Members.company_contact1_email,
			Members.company_Logo_Url,
			Country.Country_Name,
			Country.country_flag_Img_url,
			mMobileModel.ImgFile2,
			Trade_Floor.Price AS CostPrice,
			CASE WHEN Trade_Floor.Trade_Type = 1 THEN ''BUY'' ELSE ''SELL'' END AS 
			BUYSELL,
			Trade_Floor.[timestamp] AS PostingDateTime,
			DATEDIFF ( day , Trade_Floor.[timestamp] , getdate())  AS PostingDateTime_DayDiff,
			DATEDIFF ( month , Trade_Floor.[timestamp] , getdate())  AS PostingDateTime_MonthDiff,
			DATEDIFF ( year , Trade_Floor.[timestamp] , getdate())  AS PostingDateTime_YearDiff
		FROM Trade_Floor
			INNER JOIN Members
				ON Trade_Floor.member_id= Members.member_id
			--   INNER JOIN mManufacturer
			--    ON Trade_Floor.ManufCode= mManufacturer.ManufCode
			INNER JOIN Currency
				ON Trade_Floor.CurrencyCode= Currency.Currency_Code
			INNER JOIN Country Count
				ON Members.Country_ID= Count.Country_ID
			INNER JOIN Country C
				ON Trade_Floor.Country_ID = C.Country_ID
			LEFT JOIN mMobileModel
				ON (Trade_Floor.MobileSrNo = mMobileModel.SrNo OR 
				(Trade_Floor.ModelNo = mMobileModel.ModelNo AND (Trade_Floor.MobileSrNo = 0 OR 
				Trade_Floor.MobileSrNo IS NULL)))
			LEFT JOIN mManufacturer
				ON Trade_Floor.ManufCode= mManufacturer.ManufCode '
			

SET @DetailCondition = 'CROSS JOIN (SELECT TOP 1 1 AS srno 
			UNION ALL
			SELECT TOP 1 0 AS srno ) T '

SET @WHERE = ''

SET @OrderBy = 	' ORDER BY 
		Trade_Floor.[timestamp] DESC, 
		Trade_Floor.RequestDate DESC , 
		Trade_Floor.member_id ASC'

IF @Member_ID <> ''
	BEGIN
		SET @WHERE = ' WHERE Members.member_id = ''' + CAST(@Member_ID AS VARCHAR) + ''''
		EXEC ('SELECT  T.srno, ' + @SELECT +  @DetailCondition + @WHERE  + @OrderBy + ', T.srno ASC')
	END
ELSE
	BEGIN
		IF @HotOffer = 1 
			BEGIN
				SET @WHERE = ' WHERE DATEDIFF ( day , Trade_Floor.[timestamp] , getdate()) <= 7'
				EXEC ('SELECT  ' + @SELECT + @WHERE  + @OrderBy )
			END
		ELSE 	
			BEGIN	
				SET @WHERE = ' WHERE Trade_Floor.Status = 0'
				EXEC ('SELECT  T.srno, ' + @SELECT + @DetailCondition + @WHERE  + @OrderBy  + ', T.srno ASC' )
			END
	END		
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Advertisements    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Advertisements 
@Module_ID INT,
@PlaceHolder VARCHAR(50),
@Ad_Type VARCHAR(50)

AS

if Upper(@AD_Type)=Upper('Single') 
	SELECT 
		Advertisement.advert_image_url AS ImageUrl,
		'' AS NavigateUrl,
		Advertisement.advert_alt_text AS AlternateText,
		'' AS Keyword,
		'' AS Impressions
	FROM  
		Advertisement
	INNER JOIN  Advertisement_Type
		ON Advertisement_Type.Advert_Type_ID = Advertisement.Advert_Type_ID
	WHERE
		Module_ID = @Module_ID
		AND Advertisement.Ad_Position = @PlaceHolder
		AND Advertisement_Type.Advert_Type = @Ad_Type
ELSE
	SELECT Advertisement_Type.Advert_Type, Advertisement.*
	FROM  
		Advertisement
	INNER JOIN  Advertisement_Type
		ON Advertisement_Type.Advert_Type_ID = Advertisement.Advert_Type_ID
	WHERE
		Module_ID = @Module_ID
		AND Advertisement.Ad_Position = @PlaceHolder
		AND Advertisement_Type.Advert_Type = @Ad_Type


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Announcements    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_Get_Announcements
@Module_ID INT = null
AS

SELECT *
FROM  
ANNOUNCEMENTS
--WHERE
--	Module_ID = @Module_ID



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Careers    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Careers
@Module_ID INT
AS

SELECT *
FROM  
Careers
WHERE
	Module_ID = @Module_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Contact_Details    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Contact_Details
@Module_ID INT
AS

SELECT *
FROM  
Contact_Details
WHERE
	Module_ID = @Module_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Contents    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Contents
@Module_ID INT,
@Portal_ID INT = 0
AS

IF @Portal_ID = 0 
	BEGIN
		SELECT
			Content.*
		FROM  
			Content
		WHERE
			Module_ID = @Module_ID
	END
ELSE
	BEGIN	
		SELECT
			Content.*
		FROM  
			Content
		WHERE
			Module_ID = @Module_ID
			AND Portal_ID = @Portal_ID
	END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_Get_MainLinks_Modules    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE Procedure USP_Get_MainLinks_Modules
@Main_Link_ID INT,
@Sub_Link_ID INT,
@Module_Position VARCHAR(20) =''
AS

SET @Sub_Link_ID = 0

IF @Module_Position = '' 
	BEGIN
		IF @Sub_Link_ID=0
			BEGIN
				SELECT 
					Modules.*, Module_Links.Module_Position, Module_Links.Show_Flag
				FROM 
					Modules 
					INNER JOIN Module_Links 
						ON Modules.Module_ID = Module_Links.Module_ID 
				WHERE 
					Module_Links.Main_Links_ID = @Main_Link_ID
					AND Module_Links.Sub_Links_ID IS NULL
			END
		ELSE
			BEGIN
				SELECT 
					Modules.*, Module_Links.Module_Position, Module_Links.Show_Flag 
				FROM 
					Modules 
					INNER JOIN Module_Links 
						ON Modules.Module_ID = Module_Links.Module_ID 
				WHERE 
					Module_Links.Main_Links_ID = @Main_Link_ID
					AND Module_Links.Sub_Links_ID = @Sub_Link_ID
			END
	END 
ELSE
	BEGIN
		IF @Sub_Link_ID=0
			BEGIN
				SELECT 
					Modules.*, Module_Links.Module_Position, Module_Links.Show_Flag 
				FROM 
					Modules 
					INNER JOIN Module_Links 
						ON Modules.Module_ID = Module_Links.Module_ID 
				WHERE 
					Module_Links.Main_Links_ID = @Main_Link_ID
					AND Module_Links.Sub_Links_ID IS NULL
					AND Module_Links.Module_Position =@Module_Position 
			END
		ELSE
			BEGIN
				SELECT 
					Modules.* , Module_Links.Module_Position, Module_Links.Show_Flag
				FROM 
					Modules 
					INNER JOIN Module_Links 
						ON Modules.Module_ID = Module_Links.Module_ID 
				WHERE 
					Module_Links.Main_Links_ID = @Main_Link_ID
					AND Module_Links.Sub_Links_ID = @Sub_Link_ID
					AND Module_Links.Module_Position =@Module_Position 
			END
	END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Portal_Main_Links    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE Procedure USP_Get_Portal_Main_Links
@Portal_ID INT,
@Row_Position INT
AS

IF @Row_Position <= 0 
	BEGIN
		SELECT 
			Main_Links.*, (CASE WHEN Main_Links.Img_url IS NULL THEN 0 ELSE 1 END) AS Visible,
			ReMainLinks.link_name AS Redirect_Main_Link

		From 
			Main_Links
			LEFT JOIN Main_Links ReMainLinks
				ON Main_Links.Redirect_Main_Link_ID = ReMainLinks.main_links_id 
		WHERE 
			Main_Links.Portal_ID = @Portal_ID
			--AND Show_Flag = 1
		ORDER BY Main_Links.Row_Position, Main_Links.Links_Seq
	END	
ELSE
	BEGIN
		SELECT 
			Main_Links.*, (CASE WHEN Main_Links.Img_url IS NULL THEN 0 ELSE 1 END) AS Visible 
		From 
			Main_Links
		WHERE 
			Portal_ID = @Portal_ID
			AND Show_Flag = 1
			AND Row_Position = @Row_Position
		ORDER BY Row_Position, Links_Seq
	END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Portal_Main_Sub_Links    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE Procedure USP_Get_Portal_Main_Sub_Links
@Portal_ID INT,
@Main_Links_ID INT
AS


SELECT 
	Sub_Links.* 
From 
Sub_Links
INNER JOIN Main_Links
	ON Sub_Links.Main_Links_ID = Main_Links.Main_Links_ID
WHERE 
	Sub_Links.Main_Links_ID = @Main_Links_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Press_Releases    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_Get_Press_Releases
@Module_ID INT
AS

SELECT *
FROM  
Press_Release
--WHERE
--	Module_ID = @Module_ID



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Products    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Products
@Module_ID INT
AS

SELECT *
FROM  
Product
WHERE
	Module_ID = @Module_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Top_Announcements    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_Get_Top_Announcements
@No_News INT = 0
AS

IF @No_News =0
	BEGIN
		SELECT *
		FROM  
			ANNOUNCEMENTS
		WHERE Show_FLag = 1
	END
ELSE
	BEGIN
		EXEC('SELECT TOP ' + @No_News + ' *
		FROM  
			ANNOUNCEMENTS
		WHERE Show_FLag = 1')

	END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_TradingFloors    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_TradingFloors
@Portal_ID INT,
@Member_ID VARCHAR(20) =''
AS

IF @Member_ID ='' 
	SELECT Trading_Category.Trading_Cat_Desc, Trading_Floor.*,
		members.*
	FROM  
	Trading_Floor
	INNER JOIN Trading_Category
		ON Trading_Floor.trading_cat_id = Trading_Category.trading_cat_id
	INNER JOIN Members
		ON Trading_Floor.Member_id = Members.Member_id
	WHERE
		Members.Portal_id = @Portal_ID
		AND Trading_Category.Portal_id = @Portal_ID
	--	Module_ID = @Module_ID
ELSE
	SELECT Trading_Category.Trading_Cat_Desc, Trading_Floor.*,
		members.*
	FROM  
	Trading_Floor
	INNER JOIN Trading_Category
		ON Trading_Floor.trading_cat_id = Trading_Category.trading_cat_id
	INNER JOIN Members
		ON Trading_Floor.Member_id = Members.Member_id
	WHERE
		Members.Portal_id = @Portal_ID
		AND Trading_Category.Portal_id = @Portal_ID
		AND Trading_Floor.Member_ID = @Member_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_Usefullinks    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_Usefullinks
@Module_ID INT
AS

SELECT Useful_links.*
FROM  
Useful_links
WHERE
	Module_ID = @Module_ID


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Get_ValidMember    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_Get_ValidMember 
@Portal_ID INT,
@UserName VARCHAR(20),
@UserPwd VARCHAR(20)

AS

SELECT * FROM Members 
WHERE Portal_ID = @Portal_ID
AND Member_ID = @UserName
AND [Password] = @UserPwd



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ADVERTISEMENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_ADVERTISEMENT]
(
	@advert_id int = NULL output,
	@module_id int = NULL,
	@member_id varchar(20) = NULL,
	@advert_image_url varchar(200) = NULL,
	@advert_alt_text varchar(100) = NULL,
	@advert_priority varchar(2) = NULL,
	@timestamp datetime = NULL,
	@advert_type_id int = NULL,
	@ad_Position varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [ADVERTISEMENT]
	(
		[module_id],
		[member_id],
		[advert_image_url],
		[advert_alt_text],
		[advert_priority],
		[timestamp],
		[advert_type_id],
		[ad_Position]
	)
	VALUES
	(
		@module_id,
		@member_id,
		@advert_image_url,
		@advert_alt_text,
		@advert_priority,
		@timestamp,
		@advert_type_id,
		@ad_Position
	)

	SET @Err = @@Error

	SELECT @advert_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_ADVERTISEMENT_TYPE]
(
	@advert_type_id int = NULL output,
	@advert_type varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [ADVERTISEMENT_TYPE]
	(
		[advert_type]
	)
	VALUES
	(
		@advert_type
	)

	SET @Err = @@Error

	SELECT @advert_type_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_INSERT_ANNOUNCEMENTS]
(
	@ann_id int = NULL output,
	@ann_Heading varchar(255) = NULL,
	@ann_text varchar(1000) = NULL,
	@ann_textLink_Url varchar(100) = NULL,
	@timestamp datetime = NULL,
	@module_id int = NULL,
	@show_flag int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [ANNOUNCEMENTS]
	(
		[ann_text],
		[ann_Heading], 
		[ann_textLink_Url],
		[timestamp],
		[module_id],
		[show_flag]
	)
	VALUES
	(
		@ann_text,
		@ann_Heading, 
		@ann_textLink_Url,
		@timestamp,
		@module_id,
		@show_flag
	)

	SET @Err = @@Error

	SELECT @ann_id = SCOPE_IDENTITY()

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_AUDIT_TRAIL]
(
	@id int = NULL output,
	@timestamp datetime = NULL,
	@module_id int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [AUDIT_TRAIL]
	(
		[timestamp],
		[module_id]
	)
	VALUES
	(
		@timestamp,
		@module_id
	)

	SET @Err = @@Error

	SELECT @id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CAREERS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_CAREERS]
(
	@careers_id int = NULL output,
	@module_id int = NULL,
	@career_text varchar(500) = NULL,
	@member_id varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [CAREERS]
	(
		[module_id],
		[career_text],
		[member_id],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@career_text,
		@member_id,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @careers_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_CONTACT_DETAILS]
(
	@contact_id int = NULL output,
	@module_id int = NULL,
	@contact_text varchar(300) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [CONTACT_DETAILS]
	(
		[module_id],
		[contact_text],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@contact_text,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @contact_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_CONTENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_CONTENT]
(
	@content_id int = NULL output,
	@module_id int = NULL,
	@Portal_ID int = NULL,
	@content_image_url varchar(50) = NULL,
	@content_text_url varchar(50) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [CONTENT]
	(
		[module_id],
		[Portal_ID],
		[content_image_url],
		[content_text_url],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@Portal_ID,
		@content_image_url,
		@content_text_url,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @content_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_COUNTRY    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE  PROCEDURE [USP_INSERT_COUNTRY]
(
	@country_id int = NULL output,
	@country_short_code varchar(2) = NULL,
	@country_name varchar(100) = NULL,
	@country_flag_Img_url varchar(100)=NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [COUNTRY]
	(
		[country_short_code],
		[country_name],
		[country_flag_Img_url]
	)
	VALUES
	(
		@country_short_code,
		@country_name,
		@country_flag_Img_url
	)

	SET @Err = @@Error

	SELECT @country_id = SCOPE_IDENTITY()

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_ENQUIRY    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_INSERT_ENQUIRY]
(
	@Enquiry_id int = NULL output,
	@Portal_id int = NULL ,
	@ContactName varchar(100) = NULL,
	@CompanyName varchar(100) = NULL,
	@Phone varchar(100) = NULL,
	@Email varchar(255) = NULL,
	@Comments varchar(1000) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [Enquiry]
	(
		Portal_id, 
		ContactName ,
		CompanyName,
		Phone ,
		Email ,
		Comments,
		[TimeStamp]	
	)
	VALUES
	(
		@Portal_id ,
		@ContactName ,
		@CompanyName,
		@Phone ,
		@Email ,
		@Comments,
		getdate()
	)

	SET @Err = @@Error

	SELECT @Enquiry_id = SCOPE_IDENTITY()

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_EXTERNAL_WEB_SERVICES]
(
	@external_id int = NULL output,
	@module_id int = NULL,
	@external_url varchar(100) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [EXTERNAL_WEB_SERVICES]
	(
		[module_id],
		[external_url],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@external_url,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @external_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_LOGINS_AUDIT_TRAIL]
(
	@id int = NULL output,
	@member_id varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [LOGINS_AUDIT_TRAIL]
	(
		[member_id],
		[timestamp]
	)
	VALUES
	(
		@member_id,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MAIN_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_MAIN_LINKS]
(
	@main_links_id int = NULL output,
	@portal_id int = NULL,
	@link_name varchar(50) = NULL,
	@link_url varchar(100) = NULL,
	@link_open_type varchar(20) = NULL,
	@show_flag int = NULL,
	@Img_url varchar(250) = NULL,
	@Img_url_MouseOver varchar(250) = NULL,
	@Row_Position int = NULL,
	@Redirect_Main_Link_ID INT = 0,
	@Links_Seq INT = 0
)
AS
BEGIN
	IF @Redirect_Main_Link_ID = 0
		SET @Redirect_Main_Link_ID = NULL

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [MAIN_LINKS]
	(
		[portal_id],
		[link_name],
		[link_url],
		[link_open_type],
		[show_flag],
		[Img_url],
		[Img_url_MouseOver],
		[Row_Position],
		[Redirect_Main_Link_ID],
		[Links_Seq]
	)
	VALUES
	(
		@portal_id,
		@link_name,
		@link_url,
		@link_open_type,
		@show_flag,
		@Img_url,
		@Img_url_MouseOver,
		@Row_Position,
		@Redirect_Main_Link_ID,
		@Links_Seq
	)

	SET @Err = @@Error

	SELECT @main_links_id = SCOPE_IDENTITY()

	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_MASTER_ACCOUNT]
(
	@username varchar(50),
	@password varchar(20)
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [MASTER_ACCOUNT]
	(
		[username],
		[password]
	)
	VALUES
	(
		@username,
		@password
	)

	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MEMBERS    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_INSERT_MEMBERS]
(
	@member_id varchar(20),
	@portal_id int = NULL,
	@password varchar(20) = NULL,
	@member_company varchar(100) = NULL,
	@manufacturer_type varchar(1) = NULL,
	@exp_imp_type varchar(1) = NULL,
	@dealer_reseller_type varchar(1) = NULL,
	@retailer_type varchar(1) = NULL,
	@service_prov_type varchar(1) = NULL,
	@freight_type varchar(1) = NULL,
	@mailing_address varchar(500) = NULL,
	@company_phone varchar(30) = NULL,
	@company_fax varchar(30) = NULL,
	@company_email varchar(50) = NULL,
	@company_website varchar(50) = NULL,
	@company_contact1_name varchar(100) = NULL,
	@company_contact1_mobile varchar(30) = NULL,
	@company_contact1_email varchar(50) = NULL,
	@company_contact2_name varchar(100) = NULL,
	@company_contact2_mobile varchar(30) = NULL,
	@company_contact2_email varchar(50) = NULL,
	@country_id int = NULL,
	@company_Logo_Url varchar(255) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [MEMBERS]
	(
		[member_id],
		[portal_id],
		[password],
		[member_company],
		[manufacturer_type],
		[exp_imp_type],
		[dealer_reseller_type],
		[retailer_type],
		[service_prov_type],
		[freight_type],
		[mailing_address],
		[company_phone],
		[company_fax],
		[company_email],
		[company_website],
		[company_contact1_name],
		[company_contact1_mobile],
		[company_contact1_email],
		[company_contact2_name],
		[company_contact2_mobile],
		[company_contact2_email],
		[country_id],
		[company_Logo_Url]
	)
	VALUES
	(
		@member_id,
		@portal_id,
		@password,
		@member_company,
		@manufacturer_type,
		@exp_imp_type,
		@dealer_reseller_type,
		@retailer_type,
		@service_prov_type,
		@freight_type,
		@mailing_address,
		@company_phone,
		@company_fax,
		@company_email,
		@company_website,
		@company_contact1_name,
		@company_contact1_mobile,
		@company_contact1_email,
		@company_contact2_name,
		@company_contact2_mobile,
		@company_contact2_email,
		@country_id,
		@company_Logo_Url
	)

	SET @Err = @@Error


	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MEMBER_CATEGORY    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_INSERT_MEMBER_CATEGORY
@Member_ID VARCHAR(20),
@Trading_Cat_ID INT
AS

INSERT INTO Member_Category(member_id, trading_cat_id) VALUES(@Member_ID,@Trading_Cat_ID)



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MOBILEREVIEW    Script Date: 12/14/2005 1:42:25 PM ******/





CREATE PROCEDURE [USP_INSERT_MOBILEREVIEW]
(
	@MR_id int = NULL output,
	@MobileSrNo int = NULL,
	@MobileReview  varchar(1000) = NULL,
	@PortalID INT,
	@Status INT =0,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [MOBILEREVIEW]
	(
		[MobileSrNo],
		[MobileReview],
		[PortalID],
		[Status],
		[timestamp]
	)
	VALUES
	(
		@MobileSrNo,
		@MobileReview,
		@PortalID,
		@Status,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @MR_id = SCOPE_IDENTITY()

	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_MODULES    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_MODULES]
(
	@module_id int = NULL output,
	@module_name varchar(50) = NULL,
	@module_url varchar(50) = NULL,
	@module_priority int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [MODULES]
	(
		[module_name],
		[module_url],
		[module_priority]
	)
	VALUES
	(
		@module_name,
		@module_url,
		@module_priority
	)

	SET @Err = @@Error

	SELECT @module_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PORTAL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_PORTAL]
(
	@portal_id int = NULL output,
	@portal_name varchar(100) = NULL,
	@portal_url varchar(100) = NULL,
	@portal_logo varchar(50) = NULL,
	@portal_stylesheet varchar(50) = NULL,
	@portal_img_url varchar(100) = NULL,
	@portal_img_over_url varchar(100) = NULL,
	@Portal_Home_Img_Url varchar(255) = NULL,
	@Portal_Home_Text varchar(2000) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [PORTAL]
	(
		[portal_name],
		[portal_url],
		[portal_logo],
		[portal_stylesheet],
		[portal_img_url],
		[portal_img_over_url],
		[Portal_Home_Img_Url],
		[Portal_Home_Text]
	)
	VALUES
	(
		@portal_name,
		@portal_url,
		@portal_logo,
		@portal_stylesheet,
		@portal_img_url,
		@portal_img_over_url,
		@Portal_Home_Img_Url,
		@Portal_Home_Text
	)

	SET @Err = @@Error

	SELECT @portal_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PRESS_RELEASE    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_INSERT_PRESS_RELEASE]
(
	@press_release_id int = NULL output,
	@module_id int = NULL,
	@press_release_image varchar(50) = NULL,
	@press_release_text varchar(200) = NULL,
	@press_release_detail  varchar(1000) = NULL,
	@timestamp datetime = NULL,
	@Show_Flag INT =0
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [PRESS_RELEASE]
	(
		[module_id],
		[press_release_image],
		[press_release_text],
		[press_release_detail], 
		[timestamp],
		[Show_Flag]
	)
	VALUES
	(
		@module_id,
		@press_release_image,
		@press_release_text,
		@press_release_detail, 
		@timestamp,
		@Show_Flag
	)

	SET @Err = @@Error

	SELECT @press_release_id = SCOPE_IDENTITY()

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_PRODUCTS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_PRODUCTS]
(
	@product_id int = NULL output,
	@module_id int = NULL,
	@product_name varchar(20) = NULL,
	@product_short_image_url varchar(20) = NULL,
	@product_short_desc varchar(20) = NULL,
	@product_big_image_url varchar(20) = NULL,
	@product_desc varchar(20) = NULL,
	@product_web_url varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [PRODUCTS]
	(
		[module_id],
		[product_name],
		[product_short_image_url],
		[product_short_desc],
		[product_big_image_url],
		[product_desc],
		[product_web_url],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@product_name,
		@product_short_image_url,
		@product_short_desc,
		@product_big_image_url,
		@product_desc,
		@product_web_url,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @product_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_SUB_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_SUB_LINKS]
(
	@sub_links_id int = NULL output,
	@main_links_id int = NULL,
	@sub_link_name varchar(100) = NULL,
	@sub_link_url varchar(100) = NULL,
	@sub_link_open_type varchar(20) = NULL,
	@show_flag int = NULL,
	@Img_url varchar(250) = NULL,
	@Img_url_MouseOver varchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [SUB_LINKS]
	(
		[main_links_id],
		[sub_link_name],
		[sub_link_url],
		[sub_link_open_type],
		[show_flag],
		[Img_url],
		[Img_url_MouseOver]
	)
	VALUES
	(
		@main_links_id,
		@sub_link_name,
		@sub_link_url,
		@sub_link_open_type,
		@show_flag,
		@Img_url,
		@Img_url_MouseOver
	)

	SET @Err = @@Error

	SELECT @sub_links_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADE_FLOOR    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_INSERT_TRADE_FLOOR

@Trading_ID INT = 0 OUTPUT,
@post_heading	VARCHAR(100),
@Trade_Type	INT,
@Member_Id	VARCHAR(20 ),
@MobileSrNo	NUMERIC(18,0) = NULL,
@ModelNo	VARCHAR(20 ),
@ManufCode NUMERIC(18,0) = NULL,
@Quantity	INT,
@Price	NUMERIC(18,2),
@CurrencyCode	INT,
@Spec	VARCHAR(100 ) = NULL,
@Warranty	VARCHAR(100 ) = NULL,
@ProviderLogo	BIT = 0,
@Packaging	VARCHAR(100 ) = NULL,
@RequestDate	datetime,
@ShippingTerms	VARCHAR( 100)= NULL,
@Country_ID INT = 1,
@Location	VARCHAR(100)= NULL,
@post_desc	VARCHAR(1000)= NULL,
@Status	INT

AS

IF @Trading_ID = 0 
	INSERT INTO Trade_Floor
	([post_heading], [Trade_Type], 
	[Member_Id], [MobileSrNo], [ModelNo],
	[ManufCode], [Quantity], [Price], 
	[CurrencyCode], [Spec], [Warranty], 
	[ProviderLogo], [Packaging], [RequestDate], 
	[ShippingTerms], [Country_ID], [Location], [post_desc], 
	[Status], [timestamp])

	VALUES(@post_heading, @Trade_Type, @Member_Id,
	@MobileSrNo, @ModelNo, @ManufCode, @Quantity, @Price,
	@CurrencyCode, @Spec,  @Warranty, @ProviderLogo, @Packaging,
	@RequestDate, @ShippingTerms, @Country_ID, @Location, @post_desc, @Status, getdate())

SELECT @Trading_ID = SCOPE_IDENTITY()


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_TRADING_CATEGORY]
(
	@trading_cat_id int = NULL output,
	@portal_id int = NULL,
	@trading_cat_desc varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [TRADING_CATEGORY]
	(
		[portal_id],
		[trading_cat_desc]
	)
	VALUES
	(
		@portal_id,
		@trading_cat_desc
	)

	SET @Err = @@Error

	SELECT @trading_cat_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_TRADING_FLOOR    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_TRADING_FLOOR]
(
	@post_id int = NULL output,
	@module_id int = NULL,
	@post_heading varchar(100) = NULL,
	@post_desc varchar(1000) = NULL,
	@timestamp datetime = NULL,
	@trading_cat_id int = NULL,
	@Member_Id varchar(20) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [TRADING_FLOOR]
	(
		[module_id],
		[post_heading],
		[post_desc],
		[timestamp],
		[trading_cat_id],
		[Member_Id]
	)
	VALUES
	(
		@module_id,
		@post_heading,
		@post_desc,
		@timestamp,
		@trading_cat_id,
		@Member_Id
	)

	SET @Err = @@Error

	SELECT @post_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_Testimonial    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_INSERT_Testimonial 
(
@TID		int=NULL OUTPUT,
@Portal_ID	int, 
@Member_ID	varchar(20) ,
@Text	varchar(1000) ,
@TimeStamp	datetime,
@SHow_flag	int = 1
)
AS
BEGIN 
SET NOCOUNT ON
	DECLARE @Err int

	SET @TID = 0
	
	SELECT 
		@TID = ISNULL(TID,0)
	FROM 
		[Testimonials]
	WHERE
		[Portal_ID] =@Portal_ID
		AND [Member_ID]	=@Member_ID

	IF @TID > 0 
		BEGIN
			EXEC USP_UPDATE_Testimonial 
				@TID,
				@Portal_ID, 
				@Member_ID,
				@Text,
				@TimeStamp,
				@SHow_flag
			RETURN
		END

	INSERT
	INTO [Testimonials]
	(
		[Portal_ID], 
		[Member_ID],
		[Text] ,
		[TimeStamp],
		[SHow_flag]
	)
	VALUES
	(
		@Portal_ID, 
		@Member_ID ,
		@Text	 ,
		@TimeStamp,
		@SHow_flag
	)

	SET @Err = @@Error

	SELECT @TID = SCOPE_IDENTITY()

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_INSERT_USEFUL_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_INSERT_USEFUL_LINKS]
(
	@links_id int = NULL output,
	@module_id int = NULL,
	@links_url varchar(100) = NULL,
	@links_short_desc varchar(1000) = NULL,
	@links_image_url varchar(50) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [USEFUL_LINKS]
	(
		[module_id],
		[links_url],
		[links_short_desc],
		[links_image_url],
		[timestamp]
	)
	VALUES
	(
		@module_id,
		@links_url,
		@links_short_desc,
		@links_image_url,
		@timestamp
	)

	SET @Err = @@Error

	SELECT @links_id = SCOPE_IDENTITY()

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ADVERTISEMENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_ADVERTISEMENT]
(
	@advert_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @advert_id IS NULL BEGIN
	
	SELECT 
		advert_id,
		module_id,
		ADVERTISEMENT.member_id,
		advert_image_url,
		advert_alt_text,
		advert_priority,
		ADVERTISEMENT.timestamp,
		ADVERTISEMENT.advert_type_id,
		ad_Position,
		Members.member_company,
		ADVERTISEMENT_TYPE.advert_type
	FROM 
	[ADVERTISEMENT]
		INNER JOIN Members
			ON [ADVERTISEMENT].member_id = Members.member_id
		INNER JOIN ADVERTISEMENT_TYPE
			ON ADVERTISEMENT.advert_type_id = ADVERTISEMENT_TYPE.advert_type_id	
	END

	ELSE BEGIN

	SELECT 
		advert_id,
		module_id,
		ADVERTISEMENT.member_id,
		advert_image_url,
		advert_alt_text,
		advert_priority,
		ADVERTISEMENT.timestamp,
		ADVERTISEMENT.advert_type_id,
		ad_Position,
		Members.member_company,
		ADVERTISEMENT_TYPE.advert_type
		
	FROM 
	[ADVERTISEMENT] 
		INNER JOIN Members
			ON [ADVERTISEMENT].member_id = Members.member_id
		INNER JOIN ADVERTISEMENT_TYPE
			ON ADVERTISEMENT.advert_type_id = ADVERTISEMENT_TYPE.advert_type_id
	WHERE
		[advert_id] = @advert_id


END
	
	SET @Err = @@Error

	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_ADVERTISEMENT_TYPE]
(
	@advert_type_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @advert_type_id IS NULL BEGIN
	
	SELECT 
		advert_type_id,
		advert_type
	FROM 
	[ADVERTISEMENT_TYPE] 
	END

	ELSE BEGIN

	SELECT 
		advert_type_id,
		advert_type
	FROM 
	[ADVERTISEMENT_TYPE] 
	WHERE
		[advert_type_id] = @advert_type_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_ANNOUNCEMENTS]
(
	@ann_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @ann_id IS NULL BEGIN
	
	SELECT 
		ann_id,
		ann_text,
		timestamp,
		module_id,
		show_flag,
		ann_TextLink_Url,
		ann_Heading
	FROM 
	[ANNOUNCEMENTS] 
	END

	ELSE BEGIN

	SELECT 
		ann_id,
		ann_text,
		timestamp,
		module_id,
		show_flag,
		ann_TextLink_Url,
		ann_Heading
	FROM 
	[ANNOUNCEMENTS] 
	WHERE
		[ann_id] = @ann_id


END
	
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_AUDIT_TRAIL]
(
	@id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @id IS NULL BEGIN
	
	SELECT 
		id,
		timestamp,
		module_id
	FROM 
	[AUDIT_TRAIL] 
	END

	ELSE BEGIN

	SELECT 
		id,
		timestamp,
		module_id
	FROM 
	[AUDIT_TRAIL] 
	WHERE
		[id] = @id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CAREERS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_CAREERS]
(
	@careers_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @careers_id IS NULL BEGIN
	
	SELECT 
		careers_id,
		module_id,
		career_text,
		member_id,
		timestamp
	FROM 
	[CAREERS] 
	END

	ELSE BEGIN

	SELECT 
		careers_id,
		module_id,
		career_text,
		member_id,
		timestamp
	FROM 
	[CAREERS] 
	WHERE
		[careers_id] = @careers_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_CONTACT_DETAILS]
(
	@contact_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @contact_id IS NULL BEGIN
	
	SELECT 
		contact_id,
		module_id,
		contact_text,
		timestamp
	FROM 
	[CONTACT_DETAILS] 
	END

	ELSE BEGIN

	SELECT 
		contact_id,
		module_id,
		contact_text,
		timestamp
	FROM 
	[CONTACT_DETAILS] 
	WHERE
		[contact_id] = @contact_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CONTENT    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_CONTENT]
(
	@content_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @content_id IS NULL BEGIN
	
	SELECT 
		content_id,
		module_id,
		Portal_ID,
		content_image_url,
		content_text_url,
		timestamp
	FROM 
	[CONTENT] 
	END

	ELSE BEGIN

	SELECT 
		content_id,
		module_id,
		Portal_ID,
		content_image_url,
		content_text_url,
		timestamp
	FROM 
	[CONTENT] 
	WHERE
		[content_id] = @content_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_COUNTRY    Script Date: 12/14/2005 1:42:25 PM ******/




CREATE PROCEDURE [USP_SELECT_COUNTRY]
(
	@country_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @country_id IS NULL BEGIN
--select * FROM (
	SELECT 
--		CAST(1 AS INT) SrNO,
		country_id,
		country_short_code,
		country_name,
		country_flag_Img_url
	FROM 
	[COUNTRY] 
	--UNION ALL
--	SELECT 
--		CAST(0 AS INT) SrNO,
--		country_id,
--		country_short_code,
--		country_name,
--		country_flag_Img_url
--	FROM 
--	[COUNTRY] ) T ORDER BY T.country_id, T.SrNO 
	END

	ELSE BEGIN

	SELECT 
		country_id,
		country_short_code,
		country_name,
		country_flag_Img_url
	FROM 
	[COUNTRY] 
	WHERE
		[country_id] = @country_id


END
	
	SET @Err = @@Error

	RETURN @Err
END






GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_CURRENCY    Script Date: 12/14/2005 1:42:25 PM ******/


CREATE PROCEDURE USP_SELECT_CURRENCY
@Currency_Code int = null
AS


IF @Currency_Code is null
	SELECT [Currency_Code], [Currency_Symbol] FROM [Currency]
else
	SELECT [Currency_Code], [Currency_Symbol] FROM [Currency]
	WHERE Currency_Code = @Currency_Code



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_EXTERNAL_WEB_SERVICES]
(
	@external_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @external_id IS NULL BEGIN
	
	SELECT 
		external_id,
		module_id,
		external_url,
		timestamp
	FROM 
	[EXTERNAL_WEB_SERVICES] 
	END

	ELSE BEGIN

	SELECT 
		external_id,
		module_id,
		external_url,
		timestamp
	FROM 
	[EXTERNAL_WEB_SERVICES] 
	WHERE
		[external_id] = @external_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_LOGINS_AUDIT_TRAIL]
(
	@id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @id IS NULL BEGIN
	
	SELECT 
		id,
		member_id,
		timestamp
	FROM 
	[LOGINS_AUDIT_TRAIL] 
	END

	ELSE BEGIN

	SELECT 
		id,
		member_id,
		timestamp
	FROM 
	[LOGINS_AUDIT_TRAIL] 
	WHERE
		[id] = @id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_LatestMobiles    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE USP_SELECT_LatestMobiles
@SRNO int = null
AS


/*
IF @SRNO is null
	SELECT
		mMobileModel.*, mManufacturer.manufName, mManufacturer.Logo
		FROM [mLatestMobiles]
			INNER JOIN mMobileModel
			ON mLatestMobiles.SrNo = mMobileModel.SrNo
			INNER JOIN mManufacturer
				ON mMobileModel.ManufCode = mManufacturer.ManufCode
		
else
	SELECT
		mMobileModel.*, mManufacturer.manufName, mManufacturer.Logo
		FROM [mLatestMobiles]
			INNER JOIN mMobileModel
				ON mLatestMobiles.SrNo = mMobileModel.SrNo
			INNER JOIN mManufacturer
				ON mMobileModel.ManufCode = mManufacturer.ManufCode
	WHERE mLatestMobiles.SrNo = @SrNo

*/

IF @SRNO is null
	SELECT     dbo.mMobileModel.*
		FROM         dbo.mMobileModel
		WHERE     (SrNo IN (SELECT MobileSrNo FROM MobileReview where status=0))
else
	SELECT     dbo.mMobileModel.*
		FROM         dbo.mMobileModel
		WHERE     (SrNo IN (SELECT MobileSrNo FROM MobileReview where status=0))
		And SrNo = @SRNO


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MAIN_LINKS    Script Date: 12/14/2005 1:42:25 PM ******/



CREATE PROCEDURE [USP_SELECT_MAIN_LINKS]
(
	@main_links_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @main_links_id IS NULL BEGIN
	
	SELECT 
		main_links_id,
		portal_id,
		link_name,
		link_url,
		link_open_type,
		show_flag,
		Img_url,
		Img_url_MouseOver,
		Row_Position,
		Redirect_Main_Link_ID
	FROM 
	[MAIN_LINKS] 
	END

	ELSE BEGIN

	SELECT 
		main_links_id,
		portal_id,
		link_name,
		link_url,
		link_open_type,
		show_flag,
		Img_url,
		Img_url_MouseOver,
		Row_Position,
		Redirect_Main_Link_ID,
		Links_Seq
	FROM 
	[MAIN_LINKS] 
	WHERE
		[main_links_id] = @main_links_id


END
	
	SET @Err = @@Error

	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_MASTER_ACCOUNT]
(
	@username varchar(50) = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @username IS NULL BEGIN
	
	SELECT 
		username,
		password
	FROM 
	[MASTER_ACCOUNT] 
	END

	ELSE BEGIN

	SELECT 
		username,
		password
	FROM 
	[MASTER_ACCOUNT] 
	WHERE
		[username] = @username


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MEMBERS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_MEMBERS]
(
	@member_id varchar(20) = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @member_id IS NULL BEGIN
	
	SELECT 
		member_id,
		portal_id,
		password,
		member_company,
		manufacturer_type,
		exp_imp_type,
		dealer_reseller_type,
		retailer_type,
		service_prov_type,
		freight_type,
		mailing_address,
		company_phone,
		company_fax,
		company_email,
		company_website,
		company_contact1_name,
		company_contact1_mobile,
		company_contact1_email,
		company_contact2_name,
		company_contact2_mobile,
		company_contact2_email,
		company_Logo_Url,
		Country.Country_ID,
		Country.country_name,
		Country.country_flag_Img_url
	FROM 
	[MEMBERS] 
		INNER JOIN Country
			ON MEMBERS.country_id = Country.country_id
	END

	ELSE BEGIN

	SELECT 
		member_id,
		portal_id,
		password,
		member_company,
		manufacturer_type,
		exp_imp_type,
		dealer_reseller_type,
		retailer_type,
		service_prov_type,
		freight_type,
		mailing_address,
		company_phone,
		company_fax,
		company_email,
		company_website,
		company_contact1_name,
		company_contact1_mobile,
		company_contact1_email,
		company_contact2_name,
		company_contact2_mobile,
		company_contact2_email,
		company_Logo_Url,
		Country.Country_ID,
		Country.country_name,
		Country.country_flag_Img_url
	FROM 
	[MEMBERS] 
		INNER JOIN Country
			ON MEMBERS.country_id = Country.country_id
		
	WHERE
		[member_id] = @member_id


END
	
	SET @Err = @@Error

	RETURN @Err
END







GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MEMBERS_Trading_Cat    Script Date: 12/14/2005 1:42:26 PM ******/


CREATE PROCEDURE [USP_SELECT_MEMBERS_Trading_Cat]
(
	@member_id varchar(20)
)
AS
BEGIN
	
	SELECT 
		member_id,
		trading_Cat_ID	
	FROM 
	[MEMBER_CATEGORY] 

END






GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MMANUFACTURER    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE USP_SELECT_MMANUFACTURER 
@ManufCode numeric = null
AS


IF @ManufCode is null
	SELECT [SrNo], [ManufCode], [ManufName], [Logo], [ActDate] 
	FROM [mManufacturer]
ELSE
	SELECT [SrNo], [ManufCode], [ManufName], [Logo], [ActDate] 
	FROM [mManufacturer] 
	WHERE ManufCode = @ManufCode




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MMOBILEMODEL    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE USP_SELECT_MMOBILEMODEL 
@SrNo numeric = null
AS


IF @SrNo is null
	SELECT [SrNo], [ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Status], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 
	FROM [mMobileModel]
else
	SELECT [SrNo], [ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Status], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 
	FROM [mMobileModel]
WHERE SrNo = @SrNo



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MOBILEREVIEW    Script Date: 12/14/2005 1:42:26 PM ******/




CREATE PROCEDURE [USP_SELECT_MOBILEREVIEW]
(
	@MR_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @MR_id IS NULL BEGIN
	
	SELECT 
		MR_id,
		MobileSrNo,
		MobileReview,
		PortalID,
		Status,
		[timeStamp]
	FROM 
	[MOBILEREVIEW] 
	END

	ELSE BEGIN

	SELECT 
		MR_id,
		MobileSrNo,
		MobileReview,
		PortalID,
		Status,
		[timeStamp]
	FROM 
	[MOBILEREVIEW] 
	WHERE
		[MR_id] = @MR_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MOBILESECRET    Script Date: 12/14/2005 1:42:26 PM ******/






CREATE PROCEDURE [USP_SELECT_MOBILESECRET]
(
	@MS_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @MS_id IS NULL BEGIN
	
	SELECT 
		MS_id,
		MobileSrNo,
		MobileSecret,
		PortalID,
		MOBILESECRET.Status,
		[timeStamp],
		[ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 
	FROM 
	[MOBILESECRET] 
		INNER JOIN mMobileModel
			ON MOBILESECRET.MobileSrNo = mMobileModel.SrNo
	END

	ELSE BEGIN

	SELECT 
		MS_id,
		MobileSrNo,
		MobileSecret,
		PortalID,
		MOBILESECRET.Status,
		[timeStamp],
		[ModelNo], [ManufCode], [AdditionalInfo], [NetworkTypeCode], [Announced], [Weight], [Dimension], [PhoneBook], [CallRecords], [DispTypeCode], [DisplayInfo], [DispSize], [RingtoneTypeCode], [CustomizeTone], [Vibration], [BatteryInfo], [OSType], [GPRS], [DataSpeed], [SMS], [MMS], [EmailMsg], [InstantMsg], [Clock], [Alarm], [InfraRed], [BlueTooth], [Model3G], [Games], [MobileColor], [Camera], [CameraInfo], [Features], [ImgFile1], [ImgFile2], [ImgFile3], [ImgFile4], [ImgFile5], [Descriptions] 

	FROM 
	[MOBILESECRET] 
		INNER JOIN mMobileModel
			ON MOBILESECRET.MobileSrNo = mMobileModel.SrNo
	WHERE
		[MS_id] = @MS_id


END
	
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_MODULES    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_MODULES]
(
	@module_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @module_id IS NULL BEGIN
	
	SELECT 
		module_id,
		module_name,
		module_url,
		module_priority
	FROM 
	[MODULES] 
	END

	ELSE BEGIN

	SELECT 
		module_id,
		module_name,
		module_url,
		module_priority
	FROM 
	[MODULES] 
	WHERE
		[module_id] = @module_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PORTAL    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_PORTAL]
(
	@portal_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @portal_id IS NULL BEGIN
	
	SELECT 
		portal_id,
		portal_name,
		portal_url,
		portal_logo,
		portal_stylesheet,
		portal_img_url,
		portal_img_over_url,
		Portal_Home_Img_Url,
		Portal_Home_Text
	FROM 
	[PORTAL] 
	END

	ELSE BEGIN

	SELECT 
		portal_id,
		portal_name,
		portal_url,
		portal_logo,
		portal_stylesheet,
		portal_img_url,
		portal_img_over_url,
		Portal_Home_Img_Url,
		Portal_Home_Text
	FROM 
	[PORTAL] 
	WHERE
		[portal_id] = @portal_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PRESS_RELEASE    Script Date: 12/14/2005 1:42:26 PM ******/




CREATE PROCEDURE [USP_SELECT_PRESS_RELEASE]
(
	@press_release_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @press_release_id IS NULL BEGIN
	
	SELECT 
		press_release_id,
		module_id,
		press_release_image,
		press_release_text,
		press_release_detail,
		timestamp,
		Show_Flag
	FROM 
	[PRESS_RELEASE] 
	END

	ELSE BEGIN

	SELECT 
		press_release_id,
		module_id,
		press_release_image,
		press_release_text,
		press_release_detail,
		timestamp,
		Show_Flag
	FROM 
	[PRESS_RELEASE] 
	WHERE
		[press_release_id] = @press_release_id


END
	
	SET @Err = @@Error

	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_PRODUCTS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_PRODUCTS]
(
	@product_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @product_id IS NULL BEGIN
	
	SELECT 
		product_id,
		module_id,
		product_name,
		product_short_image_url,
		product_short_desc,
		product_big_image_url,
		product_desc,
		product_web_url,
		timestamp
	FROM 
	[PRODUCTS] 
	END

	ELSE BEGIN

	SELECT 
		product_id,
		module_id,
		product_name,
		product_short_image_url,
		product_short_desc,
		product_big_image_url,
		product_desc,
		product_web_url,
		timestamp
	FROM 
	[PRODUCTS] 
	WHERE
		[product_id] = @product_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_SUB_LINKS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_SUB_LINKS]
(
	@sub_links_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @sub_links_id IS NULL BEGIN
	
	SELECT 
		sub_links_id,
		main_links_id,
		sub_link_name,
		sub_link_url,
		sub_link_open_type,
		show_flag,
		Img_url,
		Img_url_MouseOver
	FROM 
	[SUB_LINKS] 
	END

	ELSE BEGIN

	SELECT 
		sub_links_id,
		main_links_id,
		sub_link_name,
		sub_link_url,
		sub_link_open_type,
		show_flag,
		Img_url,
		Img_url_MouseOver
	FROM 
	[SUB_LINKS] 
	WHERE
		[sub_links_id] = @sub_links_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TESTIMONIALS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE USP_SELECT_TESTIMONIALS
@T_ID INT = NULL

AS
IF @T_ID IS NULL
	BEGIN
		SELECT 
			Testimonials.TID,
			Testimonials.[Text] AS TText,
			Testimonials.[TimeStamp] AS TestimonialDateTime,
			Testimonials.SHow_Flag,
			Members.*
		FROM Testimonials
		INNER JOIN Members
			ON Testimonials.member_id= Members.member_id
	END
ELSE
	BEGIN
		SELECT 
			Testimonials.TID,
			Testimonials.[Text] AS TText,
			Testimonials.[TimeStamp] AS TestimonialDateTime,
			Testimonials.SHow_Flag,
			Members.*
		FROM Testimonials
		INNER JOIN Members
			ON Testimonials.member_id= Members.member_id
		WHERE 
			Testimonials.TId = @T_ID
	END








GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADE_FLOOR    Script Date: 12/14/2005 1:42:26 PM ******/


CREATE PROCEDURE USP_SELECT_TRADE_FLOOR

@Trading_ID INT = NULL

AS

IF @Trading_ID iS NULL
	SELECT 	[Trading_ID], [post_heading], [Trade_Type], 
		[Member_Id], [MobileSrNo], [ModelNo],
		[ManufCode], [Quantity], [Price], 
		[CurrencyCode], [Spec], [Warranty], 
		[ProviderLogo], [Packaging], [RequestDate], 
		[ShippingTerms], [Location], [post_desc], 
		[Status], [timestamp]
	FROM Trade_Floor
ELSE
	SELECT 	[Trading_ID], [post_heading], [Trade_Type], 
		[Member_Id], [MobileSrNo], [ModelNo],
		[ManufCode], [Quantity], [Price], 
		[CurrencyCode], [Spec], [Warranty], 
		[ProviderLogo], [Packaging], [RequestDate], 
		[ShippingTerms], [Location], [post_desc], 
		[Status], [timestamp]
	FROM Trade_Floor
	WHERE TRADING_ID = @Trading_ID




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_TRADING_CATEGORY]
(
	@trading_cat_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @trading_cat_id IS NULL BEGIN
	
	SELECT 
		trading_cat_id,
		portal_id,
		trading_cat_desc
	FROM 
	[TRADING_CATEGORY] 
	END

	ELSE BEGIN

	SELECT 
		trading_cat_id,
		portal_id,
		trading_cat_desc
	FROM 
	[TRADING_CATEGORY] 
	WHERE
		[trading_cat_id] = @trading_cat_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_TRADING_FLOOR    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_TRADING_FLOOR]
(
	@post_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @post_id IS NULL BEGIN
	
	SELECT 
		post_id,
		module_id,
		post_heading,
		post_desc,
		timestamp,
		trading_cat_id,
		Member_Id
	FROM 
	[TRADING_FLOOR] 
	END

	ELSE BEGIN

	SELECT 
		post_id,
		module_id,
		post_heading,
		post_desc,
		timestamp,
		trading_cat_id,
		Member_Id
	FROM 
	[TRADING_FLOOR] 
	WHERE
		[post_id] = @post_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_SELECT_USEFUL_LINKS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_SELECT_USEFUL_LINKS]
(
	@links_id int = NULL 
)
AS
BEGIN

	
	DECLARE @Err int
	IF @links_id IS NULL BEGIN
	
	SELECT 
		links_id,
		module_id,
		links_url,
		links_short_desc,
		links_image_url,
		timestamp
	FROM 
	[USEFUL_LINKS] 
	END

	ELSE BEGIN

	SELECT 
		links_id,
		module_id,
		links_url,
		links_short_desc,
		links_image_url,
		timestamp
	FROM 
	[USEFUL_LINKS] 
	WHERE
		[links_id] = @links_id


END
	
	SET @Err = @@Error

	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ADVERTISEMENT    Script Date: 12/14/2005 1:42:26 PM ******/


CREATE  PROCEDURE [USP_UPDATE_ADVERTISEMENT]
(
	@advert_id int,
	@module_id int = NULL,
	@member_id varchar(20) = NULL,
	@advert_image_url varchar(200) = NULL,
	@advert_alt_text varchar(100) = NULL,
	@advert_priority varchar(2) = NULL,
	@timestamp datetime = NULL,
	@advert_type_id int = NULL,
	@ad_Position varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

IF @advert_image_url is NULL OR @advert_image_url =''
	BEGIN
		UPDATE [ADVERTISEMENT]
		SET
			[module_id] = @module_id,
			[member_id] = @member_id,
--			[advert_image_url] = @advert_image_url,
			[advert_alt_text] = @advert_alt_text,
			[advert_priority] = @advert_priority,
			[timestamp] = @timestamp,
			[advert_type_id] = @advert_type_id,
			[ad_Position] = @ad_Position
		WHERE
			[advert_id] = @advert_id

	END	
ELSE
	BEGIN
		UPDATE [ADVERTISEMENT]
		SET
			[module_id] = @module_id,
			[member_id] = @member_id,
			[advert_image_url] = @advert_image_url,
			[advert_alt_text] = @advert_alt_text,
			[advert_priority] = @advert_priority,
			[timestamp] = @timestamp,
			[advert_type_id] = @advert_type_id,
			[ad_Position] = @ad_Position
		WHERE
			[advert_id] = @advert_id
	END	

	SET @Err = @@Error


	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ADVERTISEMENT_TYPE    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_ADVERTISEMENT_TYPE]
(
	@advert_type_id int,
	@advert_type varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [ADVERTISEMENT_TYPE]
	SET
		[advert_type] = @advert_type
	WHERE
		[advert_type_id] = @advert_type_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_ANNOUNCEMENTS    Script Date: 12/14/2005 1:42:26 PM ******/




CREATE PROCEDURE [USP_UPDATE_ANNOUNCEMENTS]
(
	@ann_id int = NULL output,
	@ann_Heading varchar(255) = NULL,
	@ann_text varchar(1000) = NULL,
	@ann_textLink_Url varchar(100) = NULL,
	@timestamp datetime = NULL,
	@module_id int = NULL,
	@show_flag int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [ANNOUNCEMENTS]
	SET
		[ann_text] = @ann_text,
		[ann_Heading] = @ann_Heading,
		[ann_textLink_Url] = @ann_textLink_Url ,
		[timestamp] = @timestamp,
		[module_id] = @module_id,

		[show_flag] = @show_flag
	WHERE
		[ann_id] = @ann_id


	SET @Err = @@Error


	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_AUDIT_TRAIL]
(
	@id int,
	@timestamp datetime = NULL,
	@module_id int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [AUDIT_TRAIL]
	SET
		[timestamp] = @timestamp,
		[module_id] = @module_id
	WHERE
		[id] = @id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CAREERS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_CAREERS]
(
	@careers_id int,
	@module_id int = NULL,
	@career_text varchar(500) = NULL,
	@member_id varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [CAREERS]
	SET
		[module_id] = @module_id,
		[career_text] = @career_text,
		[member_id] = @member_id,
		[timestamp] = @timestamp
	WHERE
		[careers_id] = @careers_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CONTACT_DETAILS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_CONTACT_DETAILS]
(
	@contact_id int,
	@module_id int = NULL,
	@contact_text varchar(300) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [CONTACT_DETAILS]
	SET
		[module_id] = @module_id,
		[contact_text] = @contact_text,
		[timestamp] = @timestamp
	WHERE
		[contact_id] = @contact_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_CONTENT    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_CONTENT]
(
	@content_id int,
	@module_id int = NULL,
	@Portal_ID int = NULL,
	@content_image_url varchar(50) = NULL,
	@content_text_url varchar(50) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [CONTENT]
	SET
		[module_id] = @module_id,
		[Portal_ID] = @Portal_ID,
		[content_image_url] = @content_image_url,
		[content_text_url] = @content_text_url,
		[timestamp] = @timestamp
	WHERE
		[content_id] = @content_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_COUNTRY    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_COUNTRY]
(
	@country_id int,
	@country_short_code varchar(2) = NULL,
	@country_name varchar(100) = NULL,
	@country_flag_Img_url varchar(100)=NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [COUNTRY]
	SET
		[country_short_code] = @country_short_code,
		[country_name] = @country_name,
		[country_flag_Img_url]= @country_flag_Img_url
	WHERE
		[country_id] = @country_id


	SET @Err = @@Error


	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_EXTERNAL_WEB_SERVICES    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_EXTERNAL_WEB_SERVICES]
(
	@external_id int,
	@module_id int = NULL,
	@external_url varchar(100) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [EXTERNAL_WEB_SERVICES]
	SET
		[module_id] = @module_id,
		[external_url] = @external_url,
		[timestamp] = @timestamp
	WHERE
		[external_id] = @external_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_LOGINS_AUDIT_TRAIL    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_LOGINS_AUDIT_TRAIL]
(
	@id int,
	@member_id varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [LOGINS_AUDIT_TRAIL]
	SET
		[member_id] = @member_id,
		[timestamp] = @timestamp
	WHERE
		[id] = @id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MAIN_LINKS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_MAIN_LINKS]
(
	@main_links_id int,
	@portal_id int = NULL,
	@link_name varchar(50) = NULL,
	@link_url varchar(100) = NULL,
	@link_open_type varchar(20) = NULL,
	@show_flag int = NULL,
	@Img_url varchar(250) = NULL,
	@Img_url_MouseOver varchar(250) = NULL,
	@Row_Position int = NULL,
	@Redirect_Main_Link_ID INT = 0,
	@Links_Seq INT = 0
)
AS
BEGIN
	IF @Redirect_Main_Link_ID = 0
		SET @Redirect_Main_Link_ID = NULL

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [MAIN_LINKS]
	SET
		[portal_id] = @portal_id,
		[link_name] = @link_name,
		[link_url] = @link_url,
		[link_open_type] = @link_open_type,
		[show_flag] = @show_flag,
		[Img_url] = @Img_url,
		[Img_url_MouseOver] = @Img_url_MouseOver,
		[Row_Position] = @Row_Position,
		[Redirect_Main_Link_ID] = @Redirect_Main_Link_ID,
		[Links_Seq] = @Links_Seq
	WHERE
		[main_links_id] = @main_links_id


	SET @Err = @@Error


	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MASTER_ACCOUNT    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_MASTER_ACCOUNT]
(
	@username varchar(50),
	@password varchar(20)
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [MASTER_ACCOUNT]
	SET
		[password] = @password
	WHERE
		[username] = @username


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MEMBERS    Script Date: 12/14/2005 1:42:26 PM ******/




CREATE PROCEDURE [USP_UPDATE_MEMBERS]
(
	@member_id varchar(20),
	@portal_id int = NULL,
	@password varchar(20) = NULL,
	@member_company varchar(100) = NULL,
	@manufacturer_type varchar(1) = NULL,
	@exp_imp_type varchar(1) = NULL,
	@dealer_reseller_type varchar(1) = NULL,
	@retailer_type varchar(1) = NULL,
	@service_prov_type varchar(1) = NULL,
	@freight_type varchar(1) = NULL,
	@mailing_address varchar(500) = NULL,
	@company_phone varchar(30) = NULL,
	@company_fax varchar(30) = NULL,
	@company_email varchar(50) = NULL,
	@company_website varchar(50) = NULL,
	@company_contact1_name varchar(100) = NULL,
	@company_contact1_mobile varchar(30) = NULL,
	@company_contact1_email varchar(50) = NULL,
	@company_contact2_name varchar(100) = NULL,
	@company_contact2_mobile varchar(30) = NULL,
	@company_contact2_email varchar(50) = NULL,
	@country_id int = NULL,
	@Company_Logo_Url varchar(255) = NULL

)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [MEMBERS]
	SET
		[portal_id] = @portal_id,
		[password] = @password,
		[member_company] = @member_company,
		[manufacturer_type] = @manufacturer_type,
		[exp_imp_type] = @exp_imp_type,
		[dealer_reseller_type] = @dealer_reseller_type,
		[retailer_type] = @retailer_type,
		[service_prov_type] = @service_prov_type,
		[freight_type] = @freight_type,
		[mailing_address] = @mailing_address,
		[company_phone] = @company_phone,
		[company_fax] = @company_fax,
		[company_email] = @company_email,
		[company_website] = @company_website,
		[company_contact1_name] = @company_contact1_name,
		[company_contact1_mobile] = @company_contact1_mobile,
		[company_contact1_email] = @company_contact1_email,
		[company_contact2_name] = @company_contact2_name,
		[company_contact2_mobile] = @company_contact2_mobile,
		[company_contact2_email] = @company_contact2_email,
		[country_id] = @country_id,
		[Company_Logo_Url]= @Company_Logo_Url
	WHERE
		[member_id] = @member_id


	SET @Err = @@Error


	RETURN @Err
END





GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MOBILEREVIEW    Script Date: 12/14/2005 1:42:26 PM ******/






CREATE  PROCEDURE [USP_UPDATE_MOBILEREVIEW]
(
	@MR_id int = NULL ,
	@MobileSrNo int = NULL,
	@MobileReview  varchar(1000) = NULL,
	@PortalID INT,
	@Status INT =0,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [MOBILEREVIEW]
	SET
		[MobileSrNo] = @MobileSrNo,
		[MobileReview] = @MobileReview,
		[PortalID] = @PortalID,
		[Status] = @Status,
		timestamp = getdate()

	WHERE
		[MR_id] = @MR_id


	SET @Err = @@Error


	RETURN @Err
END






GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_MODULES    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_MODULES]
(
	@module_id int,
	@module_name varchar(50) = NULL,
	@module_url varchar(50) = NULL,
	@module_priority int = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [MODULES]
	SET
		[module_name] = @module_name,
		[module_url] = @module_url,
		[module_priority] = @module_priority
	WHERE
		[module_id] = @module_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_Module_Links    Script Date: 12/14/2005 1:42:26 PM ******/




-- USP_UPDATE_Module_Links 0,21,1,null,'LEVEL1',1

CREATE  PROCEDURE USP_UPDATE_Module_Links
(
@Module_Links_ID int = NULL,
@module_id	int = NULL,
@main_links_id	int = NULL,
@sub_links_id	int = NULL,
@Module_Position varchar(20) = NULL,
@Show_flag	int = 1
)
AS
BEGIN
	SELECT TOP 1 'A' AS RESULT
	FROM Module_Links
	WHERE module_id = @module_id
		AND main_links_id = @main_links_id
		AND Module_Position = @Module_Position

	IF @@RowCount = 0 -- then Inser New One
		BEGIN
			INSERT INTO Module_Links
			(
				module_id,
				main_links_id,
				sub_links_id,
				Module_Position,
				Show_flag
			)
			VALUES
			(
				@module_id,
				@main_links_id,
				@sub_links_id,
				@Module_Position,
				1
			)
			print 'inserted'
		END
	ELSE
		BEGIN -- make it visible on i.e show_Flag= 1
			UPDATE Module_Links
			SET
				Show_flag = 1
			WHERE module_id = @module_id
				AND main_links_id = @main_links_id
				AND Module_Position = @Module_Position
			print 'updated'
		END
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PORTAL    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_PORTAL]
(
	@portal_id int,
	@portal_name varchar(100) = NULL,
	@portal_url varchar(100) = NULL,
	@portal_logo varchar(50) = NULL,
	@portal_stylesheet varchar(50) = NULL,
	@portal_img_url varchar(100) = NULL,
	@portal_img_over_url varchar(100) = NULL,
	@Portal_Home_Img_Url varchar(255) = NULL,
	@Portal_Home_Text varchar(2000) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [PORTAL]
	SET
		[portal_name] = @portal_name,
		[portal_url] = @portal_url,
		[portal_logo] = @portal_logo,
		[portal_stylesheet] = @portal_stylesheet,
		[portal_img_url] = @portal_img_url,
		[portal_img_over_url] = @portal_img_over_url,
		[Portal_Home_Img_Url] = @Portal_Home_Img_Url,
		[Portal_Home_Text] = @Portal_Home_Text
	WHERE
		[portal_id] = @portal_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PRESS_RELEASE    Script Date: 12/14/2005 1:42:26 PM ******/




CREATE PROCEDURE [USP_UPDATE_PRESS_RELEASE]
(
	@press_release_id int,
	@module_id int = NULL,
	@press_release_image varchar(50) = NULL,
	@press_release_text varchar(200) = NULL,
	@press_release_detail varchar(1000) = NULL,
	@timestamp datetime = NULL,
	@Show_Flag INT =0
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [PRESS_RELEASE]
	SET
		[module_id] = @module_id,
		[press_release_image] = @press_release_image,
		[press_release_text] = @press_release_text,
		[press_release_detail] = @press_release_detail,
		[timestamp] = @timestamp,
		[Show_Flag] =@Show_Flag 

	WHERE
		[press_release_id] = @press_release_id


	SET @Err = @@Error


	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_PRODUCTS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_PRODUCTS]
(
	@product_id int,
	@module_id int = NULL,
	@product_name varchar(20) = NULL,
	@product_short_image_url varchar(20) = NULL,
	@product_short_desc varchar(20) = NULL,
	@product_big_image_url varchar(20) = NULL,
	@product_desc varchar(20) = NULL,
	@product_web_url varchar(20) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [PRODUCTS]
	SET
		[module_id] = @module_id,
		[product_name] = @product_name,
		[product_short_image_url] = @product_short_image_url,
		[product_short_desc] = @product_short_desc,
		[product_big_image_url] = @product_big_image_url,
		[product_desc] = @product_desc,
		[product_web_url] = @product_web_url,
		[timestamp] = @timestamp
	WHERE
		[product_id] = @product_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_SUB_LINKS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_SUB_LINKS]
(
	@sub_links_id int,
	@main_links_id int = NULL,
	@sub_link_name varchar(100) = NULL,
	@sub_link_url varchar(100) = NULL,
	@sub_link_open_type varchar(20) = NULL,
	@show_flag int = NULL,
	@Img_url varchar(250) = NULL,
	@Img_url_MouseOver varchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [SUB_LINKS]
	SET
		[main_links_id] = @main_links_id,
		[sub_link_name] = @sub_link_name,
		[sub_link_url] = @sub_link_url,
		[sub_link_open_type] = @sub_link_open_type,
		[show_flag] = @show_flag,
		[Img_url] = @Img_url,
		[Img_url_MouseOver] = @Img_url_MouseOver
	WHERE
		[sub_links_id] = @sub_links_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADE_FLOOR    Script Date: 12/14/2005 1:42:26 PM ******/


CREATE PROCEDURE USP_UPDATE_TRADE_FLOOR

@Trading_ID INT = 0,
@post_heading	VARCHAR(100),
@Trade_Type	INT,
@Member_Id	VARCHAR(20 ),
@MobileSrNo	NUMERIC(18,0) = NULL,
@ModelNo	VARCHAR(20 ),
@ManufCode NUMERIC(18,0) = NULL,
@Quantity	INT,
@Price	NUMERIC(18,2),
@CurrencyCode	INT,
@Spec	VARCHAR(100 ) = NULL,
@Warranty	VARCHAR(100 ) = NULL,
@ProviderLogo	BIT = 0,
@Packaging	VARCHAR(100 ) = NULL,
@RequestDate	datetime,
@ShippingTerms	VARCHAR( 100)= NULL,
@Location	VARCHAR(100)= NULL,
@post_desc	VARCHAR(1000)= NULL,
@Status	INT

AS

UPDATE Trade_Floor
SET

[post_heading]= @post_heading, 
[Trade_Type] = @Trade_Type, 
[Member_Id]= @Member_Id,
[MobileSrNo]= @MobileSrNo,
[ModelNo]=@ModelNo,
[ManufCode]=@ManufCode,
[Quantity]=@Quantity,
[Price]=@Price,
[CurrencyCode]=@CurrencyCode,
[Spec]=@Spec,
[Warranty]=@Warranty,
[ProviderLogo]=@ProviderLogo,
[Packaging]=@Packaging,
[RequestDate]=@RequestDate,
[ShippingTerms]= @ShippingTerms,
[Location]=@Location,
[post_desc]=@post_desc,
[Status]=@Status,
[timestamp]=getdate()


WHERE 
[Trading_ID] = @Trading_ID




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADING_CATEGORY    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_TRADING_CATEGORY]
(
	@trading_cat_id int,
	@portal_id int = NULL,
	@trading_cat_desc varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [TRADING_CATEGORY]
	SET
		[portal_id] = @portal_id,
		[trading_cat_desc] = @trading_cat_desc
	WHERE
		[trading_cat_id] = @trading_cat_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_TRADING_FLOOR    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_TRADING_FLOOR]
(
	@post_id int,
	@module_id int = NULL,
	@post_heading varchar(100) = NULL,
	@post_desc varchar(1000) = NULL,
	@timestamp datetime = NULL,
	@trading_cat_id int = NULL,
	@Member_Id varchar(20) = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [TRADING_FLOOR]
	SET
		[module_id] = @module_id,
		[post_heading] = @post_heading,
		[post_desc] = @post_desc,
		[timestamp] = @timestamp,
		[trading_cat_id] = @trading_cat_id,
		[Member_Id] = @Member_Id
	WHERE
		[post_id] = @post_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_Testimonial    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE USP_UPDATE_Testimonial 
(
@TID		int ,
@Portal_ID	int, 
@Member_ID	varchar(20) ,
@Text	varchar(1000) ,
@TimeStamp	datetime,
@SHow_flag	int = 1
)
AS
BEGIN 
SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [Testimonials]
	SET
		[Portal_ID] =@Portal_ID,
		[Member_ID]	=@Member_ID,
		[Text]	=@Text,
		[TimeStamp]	=@TimeStamp,
		[SHow_flag]	=@SHow_flag
	WHERE
		[TID] = @TID


	SET @Err = @@Error


	RETURN @Err
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.USP_UPDATE_USEFUL_LINKS    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE [USP_UPDATE_USEFUL_LINKS]
(
	@links_id int,
	@module_id int = NULL,
	@links_url varchar(100) = NULL,
	@links_short_desc varchar(1000) = NULL,
	@links_image_url varchar(50) = NULL,
	@timestamp datetime = NULL
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [USEFUL_LINKS]
	SET
		[module_id] = @module_id,
		[links_url] = @links_url,
		[links_short_desc] = @links_short_desc,
		[links_image_url] = @links_image_url,
		[timestamp] = @timestamp
	WHERE
		[links_id] = @links_id


	SET @Err = @@Error


	RETURN @Err
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.USP_Valid_MasterAccount    Script Date: 12/14/2005 1:42:26 PM ******/



CREATE PROCEDURE USP_Valid_MasterAccount
@Portal_ID INT = 0,
@UserName VARCHAR(20),
@UserPwd VARCHAR(20)

AS

SELECT * FROM Master_Account
WHERE 
username = @UserName
AND [Password] = @UserPwd




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

