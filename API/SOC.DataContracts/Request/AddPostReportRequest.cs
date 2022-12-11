namespace SOC.DataContracts.Request
{
    public class AddPostReportRequest
    {
        public string Reason { get; set; } = null!;
        public Guid PostId { get; set; }
    }
}