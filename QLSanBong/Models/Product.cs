using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLSanBong.Models
{
    public partial class Product
    {
        public Product()
        {
            ImportBillDetail = new HashSet<ImportBillDetail>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; }
        public int? TypeId { get; set; }

        public virtual ProductType Type { get; set; }
        public virtual ICollection<ImportBillDetail> ImportBillDetail { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
