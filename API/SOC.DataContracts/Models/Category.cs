using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SOC.DataContracts.Request;
using Microsoft.EntityFrameworkCore;

namespace SOC.DataContracts.Models
{
    [Table("Category", Schema = "Soc")]
    [Index(nameof(Title), Name = "UQ__Category__2CB664DC9EA534E4", IsUnique = true)]
    public partial class Category : CrudEntity
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

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

        public static explicit operator Category(AddCategoryRequest c)
        {
            return new Category
            {
                Description = c.Description,
                Title = c.Title,
                ForumCreator = c.ForumCreator,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
        }
    }
}
