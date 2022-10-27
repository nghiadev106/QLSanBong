using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLSanBong.Models
{
    public partial class BillDetail
    {
        public int Id { get; set; }
        public int? PitchId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DepositDate { get; set; }
        public decimal? Deposit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartHourse { get; set; }
        public DateTime? EndHourse { get; set; }
        public int? Status { get; set; }
        public int? CountIncurredDate { get; set; }
        public int? BillId { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Pitch Pitch { get; set; }
    }
}
