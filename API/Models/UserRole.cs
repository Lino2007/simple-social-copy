using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("UserRole", Schema = "Soc")]
    public partial class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid PersonId { get; set; }

        public Guid RoleId { get; set; }


        [ForeignKey(nameof(PersonId))]
        [InverseProperty("UserRoles")]
        public virtual Person Person { get; set; } = null!;

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("UserRoles")]
        public virtual Role Role { get; set; } = null!;
    }
}
