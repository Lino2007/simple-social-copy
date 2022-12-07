namespace SOC.DataContracts.Request
{
    public class AddPostRequest
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public Guid CategoryId { get; set; }
    }
}