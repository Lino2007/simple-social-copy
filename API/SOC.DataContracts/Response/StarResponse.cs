using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class StarResponse : BaseModelResponse
    {
        public Guid PersonId { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }

        public static explicit operator StarResponse(Star s)
        {
            return new()
            {
                Id = s.Id,
                PersonId = s.PersonId,
                PostId = s.PostId,
                CommentId = s.CommentId,
                DateCreated = s.DateCreated,
                DateModified = s.DateModified
            };
        }
    }
}