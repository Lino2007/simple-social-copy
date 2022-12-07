namespace SOC.DataContracts.Request
{
    public class AddStarRequest
    {
        public Guid PersonId { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }
    }
}