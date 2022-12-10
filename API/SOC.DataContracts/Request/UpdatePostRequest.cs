namespace SOC.DataContracts.Request
{
    public class UpdatePostRequest : UpdateDto
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool? Locked { get; set; }
        public Guid CategoryId { get; set; }
    }
}