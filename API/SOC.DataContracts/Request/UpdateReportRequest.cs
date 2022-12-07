namespace SOC.DataContracts.Request
{
    public class UpdateReportRequest : UpdateRequest
    {
        public string Reason { get; set; } = null!;
        public bool Resolved { get; set; }
    }
}