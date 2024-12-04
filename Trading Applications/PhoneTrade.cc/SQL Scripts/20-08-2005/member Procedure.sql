DROP PROCEDURE [USP_INSERT_MEMBERS]
GO

CREATE PROCEDURE [USP_INSERT_MEMBERS]
(
	@member_id	varchar(20) OUTPUT,
	@portal_id	int =NULL,
	@password	varchar(20)=NULL,
	@member_company	varchar(100)=NULL,
	@manufacturer_type	varchar(1)=NULL,
	@exp_imp_type	varchar(1)=NULL,
	@dealer_reseller_type	varchar(1)=NULL,
	@retailer_type	varchar	(1)=NULL,
	@service_prov_type	varchar	(1)=NULL,
	@freight_type	varchar	(1)=NULL,
	@mailing_address	varchar(500)=NULL,
	@company_phone	varchar(30)=NULL,
	@company_fax	varchar(30)=NULL,
	@company_email	varchar(50)=NULL,
	@company_website	varchar(50)=NULL,
	@company_contact1_name	varchar(100)=NULL,
	@company_contact1_mobile	varchar(30)=NULL,
	@company_contact1_email	varchar(50)=NULL,
	@company_contact2_name	varchar(100)=NULL,
	@company_contact2_mobile	varchar(30)=NULL,
	@company_contact2_email	varchar(50) =NULL,
	@country_id	int = NULL 

)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT @member_id = ISNULL(MAX(CAST(member_id AS INT)),0) + 1 FROM MEMBERS
	INSERT
	INTO [MEMBERS]
	(
		member_id,
		portal_id,
		[password],
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
		country_id
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
		@country_id
	)

	SET @Err = @@Error

	--SELECT @country_id = SCOPE_IDENTITY()

	RETURN @Err
END


GO
