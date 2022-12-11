namespace SOC.DataContracts.Request
{
    public class AddCommentStarRequest
    {
        public Guid PersonId { get; set; }

        public Guid CommentId { get; set; }
    }
}