using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("Permission", Schema = "Soc")]
    [Index(nameof(Name), Name = "UQ__Permissi__737584F6ED64C69F", IsUnique = true)]
    public partial class Permission : ReadOnlyEntity
    {
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        [StringLength(30)]
        public string Name { get; set; } = null!;

        [InverseProperty(nameof(RolePermission.Permission))]
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
