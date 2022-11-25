using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Person", Schema = "Soc")]
    [Index(nameof(Email), Name = "UQ__Person__A9D10534CAA52FB4", IsUnique = true)]
    [Index(nameof(Nickname), Name = "UQ__Person__CC6CD17EB7866937", IsUnique = true)]
    public partial class Person
    {
        public Person()
        {
            Categories = new HashSet<Category>();
            Comments = new HashSet<Comment>();
            PersonBans = new HashSet<PersonBan>();
            Stars = new HashSet<Star>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(30)]
        public string Firstname { get; set; } = null!;

        [StringLength(30)]
        public string Lastname { get; set; } = null!;

        [StringLength(30)]
        public string Nickname { get; set; } = null!;

        [StringLength(255)]
        public string? Bio { get; set; }

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(30)]
        public string Country { get; set; } = null!;

        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }

        public Guid? PersonAuthId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }


        [ForeignKey(nameof(PersonAuthId))]
        [InverseProperty("Person")]
        public virtual PersonAuth? PersonAuth { get; set; }

        [InverseProperty(nameof(Category.ForumCreatorNavigation))]
        public virtual ICollection<Category> Categories { get; set; }

        [InverseProperty(nameof(Comment.Author))]
        public virtual ICollection<Comment> Comments { get; set; }

        [InverseProperty(nameof(PersonBan.Person))]
        public virtual ICollection<PersonBan> PersonBans { get; set; }

        [InverseProperty(nameof(Star.Person))]
        public virtual ICollection<Star> Stars { get; set; }

        [InverseProperty(nameof(UserRole.Person))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
