if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[getCountries]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[getCountries]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[getTradingCategories]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[getTradingCategories]
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE getCountries AS
SELECT * FROM Country
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE GetTradingCategories AS
SELECT * FROM Trading_Category
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

