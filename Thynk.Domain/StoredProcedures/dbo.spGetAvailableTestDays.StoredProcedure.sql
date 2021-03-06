USE [Covid19PcrDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetAvailableTestDays]    Script Date: 01/12/2021 18:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Igboanugwo Cornelius
-- Create date: 30/11/2021
-- =============================================
CREATE PROCEDURE [dbo].[spGetAvailableTestDays]
	-- Add the parameters for the stored procedure here
	@Page as int,
	@PageSize as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
select atd.Id, atd.OpenSlots, tl.LabName AS TestLab, t.City AS Location,
	atd.AvailableDate AS AvailableDate
	from AvailableTestDays atd
	inner join TestLabs tl on atd.TestLabId = tl.Id
	inner join TestLocations t on tl.TestLocationId = t.Id 
	ORDER BY atd.CreatedOn DESC
OFFSET (@pageSize * (@page -1)) ROWS FETCH NEXT @pageSize ROWS ONLY
END

GO
