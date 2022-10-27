using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLSanBong.Models
{
    public partial class ImportBill
    {
        public ImportBill()
        {
            ImportBillDetail = new HashSet<ImportBillDetail>();
        }

        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ImportBillDetail> ImportBillDetail { get; set; }
    }
}
