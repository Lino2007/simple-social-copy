using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Comment", Schema = "Soc")]
    public partial class Comment
    {
        public Comment()
        {
            Reports = new HashSet<Report>();
            Stars = new HashSet<Star>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(255)]
        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }

        public Guid PostId { get; set; }

        public bool Editable { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }


        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(Person.Comments))]
        public virtual Person Author { get; set; } = null!;

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Comments")]
        public virtual Post Post { get; set; } = null!;

        [InverseProperty(nameof(Report.Comment))]
        public virtual ICollection<Report> Reports { get; set; }

        [InverseProperty(nameof(Star.Comment))]
        public virtual ICollection<Star> Stars { get; set; }
    }
}
