using System.ComponentModel.DataAnnotations.Schema;

namespace SOC.DataContracts.Models
{
    [Table("UserRole", Schema = "Soc")]
    public partial class UserRole : CrudEntity
    {
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
