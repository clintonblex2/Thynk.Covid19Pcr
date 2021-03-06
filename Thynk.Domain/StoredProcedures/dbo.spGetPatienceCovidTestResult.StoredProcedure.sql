USE [Covid19PcrDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetPatienceCovidTestResult]    Script Date: 01/12/2021 18:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetPatienceCovidTestResult] 
	@BookingReference nvarchar(20),
	@PhoneNumber nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select CONCAT(p.FirstName, ' ',p.LastName) AS PatientName, p.PhoneNumber, p.Email, p.Age, tb.BookingReference, tb.BookingStatus, l.LabName AS TestLab, 
	tl.City AS TestLocation, v.Name AS VaccineType,
	atd.AvailableDate AS TestDate, case when ctr.ResultType = 1 then 'Result is Negative' when ctr.ResultType = 2 then 'Result is Positive'
	else 'No result yet' end as TestResult
	from CovidTestResult ctr
	inner join TestBookings tb on tb.Id = ctr.TestBookingsId
	inner join AvailableTestDays atd on tb.AvailableTestDayId = atd.Id
	inner join VaccineTypes v on tb.VaccineTypeId = v.Id
	inner join Patient p on tb.PatientId  = p.Id
	inner join TestLabs l on l.Id= atd.TestLabId
	inner join TestLocations tl on l.TestLocationId = tl.Id
	where tb.BookingReference = @BookingReference and p.PhoneNumber = @PhoneNumber
	and tb.BookingStatus='Confirmed'
		ORDER BY tb.CreatedOn DESC
END
GO
