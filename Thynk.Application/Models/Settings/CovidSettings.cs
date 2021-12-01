namespace Thynk.Covid19Pcr.Application.Models.Settings
{
    public class CovidSettings
    {
        public string SeqUrl { get; set; }
        public string KibanaUrl { get; set; }
        public int KibanaPort { get; set; }
        public bool IsWriteToKibana { get; set; }
        public bool SendMail { get; set; }
    }
}
