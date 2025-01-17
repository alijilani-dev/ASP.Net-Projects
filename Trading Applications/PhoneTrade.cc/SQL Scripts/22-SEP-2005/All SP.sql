if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_INSERT_ENQUIRY]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_INSERT_ENQUIRY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

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

