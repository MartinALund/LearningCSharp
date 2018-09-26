namespace Marubo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitWeight { get; set; }

        [StringLength(75)]
        public string Packaging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
