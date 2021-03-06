USE [Covid19PcrDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetPatienceBookedCovidTest]    Script Date: 01/12/2021 18:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Igboanugwo Cornelius
-- Create date: 30/11/2021
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetPatienceBookedCovidTest] 
	-- Add the parameters for the stored procedure here
	@bookingReference nvarchar(20)
	
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
	  WHERE tb.BookingReference = @bookingReference
		ORDER BY tb.CreatedOn DESC
END
GO
