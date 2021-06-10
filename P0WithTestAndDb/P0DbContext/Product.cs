using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductPrice { get; set; }
        public bool? Dispinibility { get; set; }
        public int? StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
