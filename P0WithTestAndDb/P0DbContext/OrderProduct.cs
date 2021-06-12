using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class OrderProduct
    {
        public int OrderProductId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }
    }
}
