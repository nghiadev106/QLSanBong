using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLSanBong.Models
{
    public partial class Pitch
    {
        public Pitch()
        {
            BillDetail = new HashSet<BillDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; }

        public virtual PitchType Type { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
    }
}
