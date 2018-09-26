namespace Marubo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyEmployee")]
    public partial class CompanyEmployee
    {
        public int? EmployeeId { get; set; }

        public int? CompanyId { get; set; }

        [Key]
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        public virtual Company Company { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
