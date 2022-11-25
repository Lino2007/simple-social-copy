using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Table("PersonBan", Schema = "Soc")]
    public partial class PersonBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

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
    }
}
