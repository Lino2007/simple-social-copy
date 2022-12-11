namespace SOC.DataContracts.Request
{
    public class AddCommentReportRequest
    {
        public string Reason { get; set; } = null!;
        public Guid CommentId { get; set; }
    }
}