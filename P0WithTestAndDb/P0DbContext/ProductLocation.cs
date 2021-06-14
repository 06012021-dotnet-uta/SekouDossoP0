using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class ProductLocation
    {
        public int ProductLocationId { get; set; }
        public int? ProductId { get; set; }
        public int? LocationId { get; set; }
    }
}
