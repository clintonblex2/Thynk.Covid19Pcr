USE [Covid19PcrDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetBookedCovidTest]    Script Date: 01/12/2021 18:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetBookedCovidTest]
	-- Add the parameters for the stored procedure here
	@from datetime,
	@to datetime,
	@page as int,
	@pageSize as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT
	p.FirstName, p.LastName, p.PhoneNumber, p.Email, p.Age, tb.BookingReference, tb.BookingStatus, tl.LabName AS TestLab, l.City AS TestLocation, v.Name AS VaccineType,
	a.AvailableDate AS TestDate
	from dbo.[TestBookings] tb 
	  inner join Patient p on tb.PatientId = p.Id 
	  inner join AvailableTestDays a on tb.AvailableTestDayId = a.Id
	  inner join VaccineTypes v on tb.VaccineTypeId = v.Id 
	  inner join TestLabs tl on a.TestLabId = tl.Id 
	  inner join TestLocations l on tl.TestLocationId = l.Id
	  where CAST(a.AvailableDate As DATE) between CAST(@from As DATE) and CAST(@to As DATE)  
	ORDER BY tb.CreatedOn DESC
OFFSET (@pageSize * (@page -1)) ROWS FETCH NEXT @pageSize ROWS ONLY
END
GO
