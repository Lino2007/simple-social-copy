namespace SOC.DataContracts.Request
{
    public class AddReportRequest
    {
        public string Reason { get; set; } = null!;
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
    }
}