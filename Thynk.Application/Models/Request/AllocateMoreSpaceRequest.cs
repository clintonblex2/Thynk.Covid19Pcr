namespace Thynk.Covid19Pcr.Application.Models.Request
{
    public class AllocateMoreSpaceRequest
    {
        public long AvailableSpaceId { get; set; }
        public int NewSlot { get; set; }
    }
}
