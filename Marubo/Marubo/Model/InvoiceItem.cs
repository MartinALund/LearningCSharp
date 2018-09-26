namespace Marubo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceItem")]
    public partial class InvoiceItem
    {
        public int InvoiceItemId { get; set; }

        public int? InvoiceId { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
