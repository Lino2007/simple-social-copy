using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class PostResponse : BaseModelResponse
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public bool? Locked { get; set; }

        public Guid CategoryId { get; set; }

        public static explicit operator PostResponse(Post p)
        {
            return new()
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                Locked = p.Locked,
                CategoryId = p.CategoryId,
                DateCreated = p.DateCreated,
                DateModified = p.DateModified
            };
        }
    }
}