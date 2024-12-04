
CREATE PROCEDURE [USP_SELECT_PARAMETER]
(
	@template_id int = NULL 
)
AS
	BEGIN
	
		DECLARE @Err int
		IF @template_id IS NULL BEGIN
	
			SELECT 
				tp.ParamID, tp.TemplateID, tp.ParamName,  
				-- ctpv.ParamValue, ctpv.CampaignID,
				pt.ParamTypeID, pt.ParamType, pt.ParamDefaultValue, replace(pt.ParamEditValue,'a','@')
			FROM 
				[TemplateParameter] tp 
					-- Inner join [Campaign_Templ_Param_Value] ctpv on tp.ParamID = ctpv.ParamID 
					Inner join [ParameterTypes] pt on tp.ParamTypeID = pt.ParamTypeID
	END

ELSE 
	BEGIN

		SELECT 
			tp.ParamID, tp.TemplateID, tp.ParamName,  '<div align="right"><font face="Verdana, Arial, Helvetica, sans-serif" color="#cc0000" size="1"><a href="javascript:GetPopup(''campid=24&paramid=36&typeid=3&fieldlength=200'');"><img src="Images/edit_icon.gif" border="0"><font face="Arial, Helvetica, sans-serif">Edit imgHeader</font></a></font></div>'  As EditText,
			-- ctpv.ParamValue, ctpv.CampaignID,
			pt.ParamTypeID, pt.ParamType, pt.ParamDefaultValue, pt.ParamEditValue
		FROM 
			[TemplateParameter] tp 
				-- Inner join [Campaign_Templ_Param_Value] ctpv on tp.ParamID = ctpv.ParamID 
				Inner join [ParameterTypes] pt on tp.ParamTypeID = pt.ParamTypeID
				where tp.TemplateID = @template_id
	END
	
	SET @Err = @@Error

	RETURN @Err
END
GO
