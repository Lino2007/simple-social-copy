using System.ComponentModel.DataAnnotations.Schema;

namespace SOC.DataContracts.Models
{
    [Table("RolePermission", Schema = "Soc")]
    public partial class RolePermission : CrudEntity
    {
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
