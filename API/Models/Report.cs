using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Report", Schema = "Soc")]
    public partial class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

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
    }
}
