using System;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Domain.Entities
{
    public class CovidTestResult
    {
        public CovidResultType ResultType { get; set; }
        public DateTime TestResultDate { get; set; }
        public CovidTestResult(CovidResultType resultType)
        {
            ResultType = resultType;
            TestResultDate = DateTime.Now;
        }
    }
}
