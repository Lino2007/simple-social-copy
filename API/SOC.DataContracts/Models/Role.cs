using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SOC.DataContracts.Models
{
    [Table("Role", Schema = "Soc")]
    [Index(nameof(Name), Name = "UQ__Role__737584F6C2FA303D", IsUnique = true)]
    public partial class Role : CrudEntity
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
        }

        [StringLength(30)]
        public string Name { get; set; } = null!;


        [InverseProperty(nameof(RolePermission.Roles))]
        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        [InverseProperty(nameof(UserRole.Role))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
