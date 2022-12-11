using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class CategoryResponse : BaseModelResponse
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid ForumCreator { get; set; }

        public static explicit operator CategoryResponse(Category c)
        {
            return new()
            {
                Id = c.Id,
                Description = c.Description,
                Title = c.Title,
                ForumCreator = c.ForumCreator,
                DateCreated = c.DateCreated,
                DateModified = c.DateModified
            };
        }
    }
}