namespace SOC.DataContracts.Request
{
    public class AddCommentRequest
    {
        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }

        public Guid PostId { get; set; }
    }
}