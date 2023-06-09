﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SOC.DataContracts.Models
{
    [Table("PersonAuth", Schema = "Soc")]
    [Index(nameof(Salt), Name = "UQ__PersonAu__A152BCCE4BED49AC", IsUnique = true)]
    public partial class PersonAuth : CrudEntity
    {
        [StringLength(128)]
        public string Password { get; set; } = null!;

        [StringLength(36)]
        public string Salt { get; set; } = null!;

        [Column(TypeName = "datetime")]
        public DateTime? ExpireDate { get; set; }

        [InverseProperty("PersonAuth")]
        public virtual Person? Person { get; set; }
    }
}
