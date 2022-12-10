using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SOC.DataContracts.Request;

namespace SOC.DataContracts.Models
{
    [Table("Post", Schema = "Soc")]
    public partial class Post : CrudEntity
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Reports = new HashSet<Report>();
            Stars = new HashSet<Star>();
        }

        [StringLength(50)]
        public string Title { get; set; } = null!;

        [StringLength(2048)]
        public string Content { get; set; } = null!;

        [Required]
        public bool? Locked { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Posts")]
        public virtual Category Category { get; set; } = null!;

        [InverseProperty(nameof(Comment.Post))]
        public virtual ICollection<Comment> Comments { get; set; }

        [InverseProperty(nameof(Report.Post))]
        public virtual ICollection<Report> Reports { get; set; }

        [InverseProperty(nameof(Star.Post))]
        public virtual ICollection<Star> Stars { get; set; }

        public static explicit operator Post(AddPostRequest p)
        {
            return new Post
            {
                Title = p.Title,
                Content = p.Content,
                CategoryId = p.CategoryId,
                Locked = false
            };
        }
    }
}
