using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Post", Schema = "Soc")]
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Reports = new HashSet<Report>();
            Stars = new HashSet<Star>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; } = null!;

        [StringLength(2048)]
        public string Content { get; set; } = null!;

        [Required]
        public bool? Locked { get; set; }

        public Guid CategoryId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }


        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Posts")]
        public virtual Category Category { get; set; } = null!;

        [InverseProperty(nameof(Comment.Post))]
        public virtual ICollection<Comment> Comments { get; set; }

        [InverseProperty(nameof(Report.Post))]
        public virtual ICollection<Report> Reports { get; set; }

        [InverseProperty(nameof(Star.Post))]
        public virtual ICollection<Star> Stars { get; set; }
    }
}
