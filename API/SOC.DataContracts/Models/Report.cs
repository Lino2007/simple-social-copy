using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SOC.DataContracts.Request;

namespace SOC.DataContracts.Models
{
    [Table("Report", Schema = "Soc")]
    public partial class Report : CrudEntity
    {
        [StringLength(255)]
        public string Reason { get; set; } = null!;

        public bool Resolved { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }

        [ForeignKey(nameof(CommentId))]
        [InverseProperty("Reports")]
        public virtual Comment? Comment { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Reports")]
        public virtual Post? Post { get; set; }

        public static explicit operator Report(AddCommentReportRequest v)
        {
            return new()
            {
                Reason = v.Reason,
                Resolved = false,
                PostId = null,
                CommentId = v.CommentId
            };
        }

        public static explicit operator Report(AddPostReportRequest v)
        {
            return new()
            {
                Reason = v.Reason,
                Resolved = false,
                PostId = v.PostId,
                CommentId = null
            };
        }
    }
}
