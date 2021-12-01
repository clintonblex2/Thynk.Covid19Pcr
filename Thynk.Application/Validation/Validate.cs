using Thynk.Covid19Pcr.Application.Models.Request;

namespace Thynk.Covid19Pcr.Application.Validation
{
    public static class Validate
    {
        public static bool ValidateRequest(PaginatedRequest request)
        {
            if (request.From > request.To)
                return false;

            if (request.Page < 1)
                request.Page = 1;

            if (request.PageSize < 1)
                request.PageSize = 20;

            return true;
        }
    }
}
