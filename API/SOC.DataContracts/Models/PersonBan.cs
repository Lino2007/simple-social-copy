using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SOC.DataContracts.Request;

namespace SOC.DataContracts.Models
{
    [Table("PersonBan", Schema = "Soc")]
    public partial class PersonBan : CrudEntity
    {
        public bool Active { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActiveUntil { get; set; }

        [StringLength(350)]
        public string Reason { get; set; } = null!;

        public Guid PersonId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }


        [ForeignKey(nameof(PersonId))]
        [InverseProperty("PersonBans")]
        public virtual Person Person { get; set; } = null!;

        public static explicit operator PersonBan(AddPersonBanRequest v)
        {
            return new PersonBan
            {
                Active = v.Active,
                ActiveUntil = v.ActiveUntil,
                Reason = v.Reason,
                PersonId = v.PersonId,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
        }
    }
}
