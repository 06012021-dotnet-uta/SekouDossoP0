using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class StoreProduct
    {
        public int StoreProductId { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public int StoreProductQuantity { get; set; }
    }
}
