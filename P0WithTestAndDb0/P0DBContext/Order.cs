using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime? OderDate { get; set; }
        public int? UserId { get; set; }
        public int? LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }
}
