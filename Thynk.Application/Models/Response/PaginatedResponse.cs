namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class PaginatedResponse
    {
        public long TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public long TotalPages { get; set; }
        public dynamic Data { get; set; }
    }
}
