using System.ComponentModel;

namespace Thynk.Covid19Pcr.Domain.Enums
{
    public enum Formats
    {
        [Description("application/vnd.openxml")]
        Excel,
        [Description("application/pdf")]
        Pdf
    }
}
