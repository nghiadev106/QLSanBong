using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLSanBong.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ImportBill = new HashSet<ImportBill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ImportBill> ImportBill { get; set; }
    }
}
