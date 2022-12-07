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

        [Column(TypeName = "date")]
        public DateTime DateSubmitted { get; set; }

        public bool Resolved { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }


        [ForeignKey(nameof(CommentId))]
        [InverseProperty("Reports")]
        public virtual Comment? Comment { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Reports")]
        public virtual Post? Post { get; set; }

        public static explicit operator Report(AddReportRequest v)
        {
            return new Report
            {
                Reason = v.Reason,
                DateSubmitted = DateTime.Now,
                Resolved = false,
                PostId = v.PostId,
                CommentId = v.CommentId
            };
        }
    }
}
