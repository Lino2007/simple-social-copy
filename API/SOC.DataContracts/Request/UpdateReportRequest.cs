namespace SOC.DataContracts.Request
{
    public class UpdateReportRequest : UpdateDto
    {
        public string Reason { get; set; } = null!;
        public bool Resolved { get; set; }
    }
}