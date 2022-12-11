using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class CommentResponse : BaseModelResponse
    {
        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }

        public Guid PostId { get; set; }

        public bool Editable { get; set; }

        public static explicit operator CommentResponse(Comment c)
        {
            return new()
            {
                Id = c.Id,
                Content = c.Content,
                AuthorId = c.AuthorId,
                PostId = c.PostId,
                Editable = c.Editable,
                DateCreated = c.DateCreated,
                DateModified = c.DateModified
            };
        }
    }
}