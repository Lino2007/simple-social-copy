using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("RolePermission", Schema = "Soc")]
    public partial class RolePermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Guid PermissionId { get; set; }

        public Guid RolesId { get; set; }


        [ForeignKey(nameof(PermissionId))]
        [InverseProperty("RolePermissions")]
        public virtual Permission Permission { get; set; } = null!;

        [ForeignKey(nameof(RolesId))]
        [InverseProperty(nameof(Role.RolePermissions))]
        public virtual Role Roles { get; set; } = null!;
    }
}
