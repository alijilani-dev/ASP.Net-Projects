DROP PROCEDURE USP_GET_TRADE_FLOOR
GO

CREATE PROCEDURE USP_GET_TRADE_FLOOR
@Portal_ID INT,
@Member_ID VARCHAR(20) = ''
AS

IF @Member_ID <> ''
	SELECT 	
		mManufacturer.ManufName AS Brand,
		(CASE WHEN Trade_Floor.MobileSrNo IS NULL THEN Trade_Floor.ModelNo ELSE mMobileModel.ModelNo END) AS MODELNo,
		Trade_Floor.Quantity, 
		CAST(Trade_Floor.Price AS VARCHAR) + Currency.Currency_Symbol AS Price, 
		(CASE WHEN Trade_Floor.Status = 0 THEN 'NEW' ELSE '' END) AS Status,
		Trade_Floor.Spec, 
	
		Trade_Floor.Trading_ID, Trade_Floor.post_heading, Trade_Floor.Trade_Type, 
		Trade_Floor.Member_Id, Trade_Floor.MobileSrNo, 	
	
		Trade_Floor.ManufCode, 
	
		Trade_Floor.CurrencyCode, Trade_Floor.Warranty, 
		Trade_Floor.ProviderLogo, Trade_Floor.Packaging, Trade_Floor.RequestDate, 
		Trade_Floor.ShippingTerms, Trade_Floor.Location, Trade_Floor.post_desc,
		mManufacturer.Logo,
		Members.company_email,
		Members.company_contact1_email,
		Members.company_Logo_Url,
		Country.Country_Name,
		Country.country_flag_Img_url,
		mMobileModel.ImgFile2,
		Trade_Floor.Price AS CostPrice
	FROM Trade_Floor
	INNER JOIN Members
		ON Trade_Floor.member_id= Members.member_id
	INNER JOIN mManufacturer
		ON Trade_Floor.ManufCode= mManufacturer.ManufCode
	INNER JOIN Currency
		ON Trade_Floor.CurrencyCode= Currency.Currency_Code
	INNER JOIN Country
		ON Members.Country_ID= Country.Country_ID
	LEFT JOIN mMobileModel
		ON Trade_Floor.MobileSrNo= mMobileModel.SrNo

	WHERE 
		Members.member_id = @Member_ID
ELSE
	SELECT 	
		mManufacturer.ManufName AS Brand,
		(CASE WHEN Trade_Floor.MobileSrNo IS NULL THEN Trade_Floor.ModelNo ELSE mMobileModel.ModelNo END) AS MODELNo,
		Trade_Floor.Quantity, 
		CAST(Trade_Floor.Price AS VARCHAR) + Currency.Currency_Symbol AS Price, 
		(CASE WHEN Trade_Floor.Status = 0 THEN 'NEW' ELSE '' END) AS Status,
		Trade_Floor.Spec, 
	
		Trade_Floor.Trading_ID, Trade_Floor.post_heading, Trade_Floor.Trade_Type, 
		Trade_Floor.Member_Id, Trade_Floor.MobileSrNo, 	
	
		Trade_Floor.ManufCode, 
	
		Trade_Floor.CurrencyCode, Trade_Floor.Warranty, 
		Trade_Floor.ProviderLogo, Trade_Floor.Packaging, Trade_Floor.RequestDate, 
		Trade_Floor.ShippingTerms, Trade_Floor.Location, Trade_Floor.post_desc,
		mManufacturer.Logo,
		Members.company_email,
		Members.company_contact1_email,
		Members.company_Logo_Url,
		Country.Country_Name,
		Country.country_flag_Img_url,
		mMobileModel.ImgFile2,
		Trade_Floor.Price AS CostPrice
	FROM Trade_Floor
	INNER JOIN Members
		ON Trade_Floor.member_id= Members.member_id
	INNER JOIN mManufacturer
		ON Trade_Floor.ManufCode= mManufacturer.ManufCode
	INNER JOIN Currency
		ON Trade_Floor.CurrencyCode= Currency.Currency_Code
	INNER JOIN Country
		ON Members.Country_ID= Country.Country_ID
	LEFT JOIN mMobileModel
		ON Trade_Floor.MobileSrNo= mMobileModel.SrNo



