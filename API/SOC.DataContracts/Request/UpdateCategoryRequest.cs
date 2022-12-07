namespace SOC.DataContracts.Request
{
    public class UpdateCategoryRequest : UpdateRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}