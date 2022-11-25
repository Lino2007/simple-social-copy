using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Role", Schema = "Soc")]
    [Index(nameof(Name), Name = "UQ__Role__737584F6C2FA303D", IsUnique = true)]
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; } = null!;


        [InverseProperty(nameof(RolePermission.Roles))]
        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        [InverseProperty(nameof(UserRole.Role))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
