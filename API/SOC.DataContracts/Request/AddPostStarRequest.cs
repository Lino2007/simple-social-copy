namespace SOC.DataContracts.Request
{
    public class AddPostStarRequest
    {
        public Guid PersonId { get; set; }

        public Guid PostId { get; set; }
    }
}