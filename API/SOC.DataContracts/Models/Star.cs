using System.ComponentModel.DataAnnotations.Schema;
using SOC.DataContracts.Request;

namespace SOC.DataContracts.Models
{
    [Table("Star", Schema = "Soc")]
    public partial class Star : CrudEntity
    {
        public Guid PersonId { get; set; }

        public Guid? PostId { get; set; }

        public Guid? CommentId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [ForeignKey(nameof(CommentId))]
        [InverseProperty("Stars")]
        public virtual Comment? Comment { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("Stars")]
        public virtual Person Person { get; set; } = null!;

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Stars")]
        public virtual Post? Post { get; set; }

        public static explicit operator Star(AddStarRequest v)
        {
            return new Star
            {
                PersonId = v.PersonId,
                CommentId = v.CommentId,
                DateCreated = DateTime.Now,
                PostId = v.PostId
            };
        }
    }
}
