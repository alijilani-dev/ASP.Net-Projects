if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_MainLinks_Modules]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_MainLinks_Modules]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Get_Portal_Main_Links]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[USP_Get_Portal_Main_Links]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE Procedure USP_Get_MainLinks_Modules
@Main_Link_ID INT,
@Module_Position VARCHAR(20) =''
AS

IF @Module_Position = '' 
	BEGIN
		SELECT 
			Modules.* 
		FROM 
			Modules 
			INNER JOIN Module_Links 
				ON Modules.Module_ID = Module_Links.Module_ID 
		WHERE 
			Module_Links.Main_Links_ID = @Main_Link_ID
	END 
ELSE
	BEGIN
		SELECT 
			Modules.* 
		FROM 
			Modules 
			INNER JOIN Module_Links 
				ON Modules.Module_ID = Module_Links.Module_ID 
		WHERE 
			Module_Links.Main_Links_ID = @Main_Link_ID
			AND Modules.Module_Position =@Module_Position 
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

CREATE Procedure USP_Get_Portal_Main_Links
@Portal_ID INT
AS


SELECT 
	Main_Links.* 
From 
	Main_Links
WHERE 
	Portal_ID = @Portal_ID




	

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

