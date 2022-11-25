using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Category", Schema = "Soc")]
    [Index(nameof(Title), Name = "UQ__Category__2CB664DC9EA534E4", IsUnique = true)]
    public partial class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(30)]
        public string Title { get; set; } = null!;

        [StringLength(255)]
        public string Description { get; set; } = null!;

        public Guid ForumCreator { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }

        [ForeignKey(nameof(ForumCreator))]
        [InverseProperty(nameof(Person.Categories))]
        public virtual Person ForumCreatorNavigation { get; set; } = null!;

        [InverseProperty(nameof(Post.Category))]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
