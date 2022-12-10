using System.ComponentModel.DataAnnotations.Schema;

namespace SOC.DataContracts.Models
{
    [Table("RolePermission", Schema = "Soc")]
    public partial class RolePermission : CrudEntity
    {
        public Guid PermissionId { get; set; }

        public Guid RoleId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        [InverseProperty("RolePermissions")]
        public virtual Permission Permission { get; set; } = null!;

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(Role.RolePermissions))]
        public virtual Role Roles { get; set; } = null!;
    }
}
