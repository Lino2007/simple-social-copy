using SOC.DataContracts.Models;

namespace SOC.DataContracts.Response
{
    public class ReportResponse : BaseModelResponse
    {
        public string Reason { get; set; } = null!;

        public bool Resolved { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }

        public static explicit operator ReportResponse(Report r)
        {
            return new()
            {
                Id = r.Id,
                Reason = r.Reason,
                Resolved = r.Resolved,
                PostId = r.PostId,
                CommentId = r.CommentId,
                DateCreated = r.DateCreated,
                DateModified = r.DateModified
            };
        }
    }
}