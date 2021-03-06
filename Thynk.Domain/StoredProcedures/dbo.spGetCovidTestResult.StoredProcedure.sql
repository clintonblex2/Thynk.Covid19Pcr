USE [Covid19PcrDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetCovidTestResult]    Script Date: 01/12/2021 18:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Igboanugwo Cornelius
-- Create date: 30/11/2021
-- =============================================
CREATE PROCEDURE [dbo].[spGetCovidTestResult] 
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
	
	select CONCAT(p.FirstName, ' ',p.LastName) AS PatientName, tb.BookingReference, tb.BookingStatus, l.LabName AS TestLab, 
	tl.City AS TestLocation, v.Name AS VaccineType,
	atd.AvailableDate AS TestDate, case when ctr.ResultType = 1 then 'Result is Negative' when ctr.ResultType = 2 then 'Result is Positive' else 'No result yet' end as TestResult
	from CovidTestResult ctr
	inner join TestBookings tb on tb.Id = ctr.TestBookingsId
	inner join AvailableTestDays atd on tb.AvailableTestDayId = atd.Id
	inner join VaccineTypes v on tb.VaccineTypeId = v.Id
	inner join Patient p on tb.PatientId  = p.Id
	inner join TestLabs l on l.Id= atd.TestLabId
	inner join TestLocations tl on l.TestLocationId = tl.Id
	where CAST(atd.AvailableDate As DATE) between CAST(@from As DATE) and CAST(@to As DATE)  
	ORDER BY tb.CreatedOn DESC
OFFSET (@pageSize * (@page -1)) ROWS FETCH NEXT @pageSize ROWS ONLY

END
GO
