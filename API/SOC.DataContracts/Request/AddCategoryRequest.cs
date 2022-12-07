namespace SOC.DataContracts.Request
{
    public class AddCategoryRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid ForumCreator { get; set; }
    }
}