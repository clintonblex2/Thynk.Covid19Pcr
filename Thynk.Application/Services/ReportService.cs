using AutoMapper;
using Hangfire;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Application.Interfaces.Repositories;
using Thynk.Covid19Pcr.Application.Interfaces.Service;
using Thynk.Covid19Pcr.Application.Models.Request;
using Thynk.Covid19Pcr.Application.Models.ViewModels;
using Thynk.Covid19Pcr.Domain.Entities;
using Thynk.Covid19Pcr.Domain.Enums;
using Thynk.Covid19Pcr.Domain.Helpers;

namespace Thynk.Covid19Pcr.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly ILogger<ReportService> _logger;
        private readonly IUnitOfWork _uow;
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public ReportService(ILogger<ReportService> logger, IUnitOfWork uow,
            IAdminService backoffice, IMapper mapper)
        {
            _logger = logger;
            _uow = uow;
            _adminService = backoffice;
            _mapper = mapper;
        }

        public ExecutedResult<List<string>> GetReportTypes()
        {
            var result = Enum.GetValues(typeof(ReportTypes)).Cast<ReportTypes>().Select(s => s.ToString()).ToList();
            return ExecutedResult<List<string>>.Success(result);
        }

        public async Task<ExecutedResult<string>> CancelReport(long id)
        {
            var report = await _uow.Repository<ReportEntity>().FindAsync(x => x.Id == id);
            if (report == null)
                return ExecutedResult<string>.Failed();

            if (report.ReportStatus == ReportStatus.Pending.ToString() || report.ReportStatus == ReportStatus.Processing.ToString())
            {
                report.ReportStatus = ReportStatus.Cancelled.ToString();
                report.CancelledOn = report.LastModifiedOn = DateTime.Now;

                await _uow.CommitAsync();

                return ExecutedResult<string>.Success("Report successfully cancelled");
            }

            return ExecutedResult<string>.Success("Report has already been cancelled or processed");
        }

        public async Task<ExecutedResult<string>> CreateReport(ReportRequest request)
        {
            _logger.LogInformation("Thynk.Covid: Create Report {@request}", request);
            if (!EnumHelper<ReportTypes>.IsDefined(request.ReportType))
                return ExecutedResult<string>.Failed("Invalid report type");

            var report = new ReportEntity
            {
                ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Format = Formats.Excel,
                CreatedOn = DateTime.Now,
                From = request.From,
                To = request.To,
                ReportStatus = ReportStatus.Pending.ToString(),
                RequestObject = System.Text.Json.JsonSerializer.Serialize(request),
                ReportName = request.ReportType
            };

            _uow.Repository<ReportEntity>().Add(report);

            await _uow.CommitAsync();

            BackgroundJob.Schedule(() => ReportGenerator(), TimeSpan.FromSeconds(5));

            return ExecutedResult<string>.Success(null, $"Report with ID {report.Id} was added successfully, kindly hold on while we generate the report...");
        }

        public async Task<ExecutedResult<ReportEntity>> DownloadReport(long Id)
        {
            var file = await _uow.Repository<ReportEntity>().FindAsync(x => x.Id == Id);

            if (file == null)
                return ExecutedResult<ReportEntity>.Failed("Report file not found...");

            if (file.ReportStatus.ToUpper() == "READY")
                return ExecutedResult<ReportEntity>.Success(file, "Downloading file...");

            return ExecutedResult<ReportEntity>.Failed("Report is still processing...");
        }

        public async Task<ExecutedResult<IEnumerable<GetReportVm>>> GetReports()
        {
            var result = await _uow.Repository<ReportEntity>().GetAllAsNoTracking(x => !x.IsExpired && x.ReportStatus.ToUpper() != "PROCESSING");
            if (!result.Any())
                return ExecutedResult<IEnumerable<GetReportVm>>.Failed();

            return ExecutedResult<IEnumerable<GetReportVm>>.Success(result.Select(v => new GetReportVm
            {
                ReportStatus = v.ReportStatus,
                ReportType = v.ReportName,
                Id = v.Id,
                ReportRange = $"{v.From?.ToString("MM/dd/yyyy")} To {v.To?.ToString("MM/dd/yyyy")}",
                RequestedOn = v.CreatedOn,
                CancelledOn = v.CancelledOn,
                TreatedOn = v.TreatedOn
            }).OrderByDescending(x => x.RequestedOn));
        }

        public async Task ReportGenerator()
        {
            var pendingReports = _uow.Repository<ReportEntity>().Get(x => x.ReportStatus.ToUpper() == "PENDING");

            if (!pendingReports.Any())
                return;

            foreach (var report in pendingReports)
            {
                string fileName = @"" + report.ReportName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "." + GetFormat(report.Format);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new())
                {
                    // add a new worksheet to the new empty worksheet
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(report.ReportName ?? "Covid19Report");
                    worksheet.Row(1).Height = 25;
                    worksheet.Row(1).Style.Font.Size = 12;
                    worksheet.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    if (Utils.IsNull(report?.ReportName))
                        continue;

                    ReportTypes reportType = (ReportTypes)Enum.Parse(typeof(ReportTypes), report.ReportName);

                    if (reportType == ReportTypes.CovidResult)
                    {
                        var request = System.Text.Json.JsonSerializer.Deserialize<ReportRequest>(report.RequestObject);
                        request.PageSize = 999999999;

                        var backofficeRequest = _mapper.Map<CovidTestResultRequest>(request);

                        report.ReportStatus = ReportStatus.Processing.ToString();
                        report.FileName = fileName;

                        var data = _adminService.GetCovidPcrTestResult(backofficeRequest);
                       
                        if (data.Response == ResponseCode.Success && data.Result.TotalCount > 0)
                        {
                            // First add the headers
                            worksheet.Cells[1, 1].Value = "S/N";
                            worksheet.Cells[1, 2].Value = "Patient Name";
                            worksheet.Cells[1, 3].Value = "Booking Reference";
                            worksheet.Cells[1, 4].Value = "Test Lab";
                            worksheet.Cells[1, 5].Value = "Vaccine Type";
                            worksheet.Cells[1, 6].Value = "Test Date";
                            worksheet.Cells[1, 7].Value = "BookingStatus";
                            worksheet.Cells[1, 8].Value = "Test Result";

                            var generatedReport = (List<TestResultVm>)data.Result.Data;

                            var i = 2;
                            int counter = 1;

                            foreach (var r in generatedReport)
                            {
                                worksheet.Cells["A" + i].Value = counter;
                                worksheet.Cells["B" + i].Value = r.PatientName;
                                worksheet.Cells["C" + i].Value = r.BookingReference;
                                worksheet.Cells["D" + i].Value = r.TestLab;
                                worksheet.Cells["E" + i].Value = r.VaccineType;
                                worksheet.Cells["F" + i].Value = r.TestDate.ToString();
                                worksheet.Cells["G" + i].Value = r.BookingStatus;
                                worksheet.Cells["H" + i].Value = r.TestResult;

                                i++;
                                counter++;
                            }

                            // format the values
                            FormatSheet(worksheet, i, 'H', 8);

                            UpdateReport(excelPackage, report, false);
                        }
                        else
                            UpdateReport(excelPackage, report, true);
                    }
                }
            }

            await _uow.CommitAsync();
        }

        #region Private Methods
        private void FormatSheet(ExcelWorksheet worksheet, int i, char toCol, int toRow)
        {
            // format the values
            using (var range = worksheet.Cells[1, 1, 1, toRow])
            {
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#6b188c"));
                range.Style.Font.Color.SetColor(Color.White);
                //range.AutoFilter = true
                range.AutoFitColumns();
            }

            i += 1;

            // create autofilter for the range
            worksheet.Cells[$"A{2}:{toCol}{i + 2}"].AutoFitColumns();

            // set the header text
            worksheet.HeaderFooter.OddHeader.CenteredText = "&24&U&\"Arial,Regular Bold\"Thynk Software Covid-19 Report";
            // add the page number to the footer plus the total number of pages
            worksheet.HeaderFooter.OddFooter.RightAlignedText =
            string.Format("Page {0} of {1}", ExcelHeaderFooter.PageNumber, ExcelHeaderFooter.NumberOfPages);
            // add the sheet name to the footer
            worksheet.HeaderFooter.OddFooter.CenteredText = ExcelHeaderFooter.SheetName;
            // add the file path to the footer
            worksheet.HeaderFooter.OddFooter.LeftAlignedText = ExcelHeaderFooter.FilePath + ExcelHeaderFooter.FileName;

            worksheet.PrinterSettings.RepeatRows = worksheet.Cells[$"1:{i + 1}"];
            worksheet.PrinterSettings.RepeatColumns = worksheet.Cells[$"A:{toCol}"];
        }

        private void UpdateReport(ExcelPackage excelPackage, ReportEntity reportReq, bool IsEmpty)
        {
            ParameterCheck(excelPackage, reportReq);

            byte[] fileContents;

            if (IsEmpty)
            {
                fileContents = excelPackage.GetAsByteArray();
                reportReq.FileName = @"" + reportReq.ReportName + "_NoRecordFound" + GetFormat(reportReq.Format);
            }
            else
            {
                // set some document properties
                excelPackage.Workbook.Properties.Title = "Powered by Thynk Software";
                
                // set some extended property values
                excelPackage.Workbook.Properties.Company = "Thynk Software";

                fileContents = excelPackage.GetAsByteArray();
            }

            reportReq.FileContent = fileContents;
            reportReq.ReportStatus = ReportStatus.Ready.ToString();
            reportReq.TreatedOn = DateTime.Now;
        }

        public static string GetFormat(Formats reportContentType)
        {
            return reportContentType switch
            {
                Formats.Excel => "xlsx",
                Formats.Pdf => "pdf",
                _ => "xlsx",
            };
        }

        public static void ParameterCheck(ExcelPackage excelPackage, ReportEntity report)
        {
            if (excelPackage == null || report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }
        }
        #endregion
    }
}
