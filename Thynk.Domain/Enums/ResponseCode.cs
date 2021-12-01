using System.ComponentModel;

namespace Thynk.Covid19Pcr.Domain.Enums
{
    public enum ResponseCode
    {
        [Description("Success")]
        Success = 0,
        [Description("Validation Error")]
        ValidationError = 1,
        [Description("Not Found")]
        NotFound = 2,
        [Description("Bad Request")]
        ProcessingError = 3,
        [Description("Unauthorized Access")]
        AuthorizationError = 4,
        [Description("Exception Occurred")]
        Exception = 5
    }
}
