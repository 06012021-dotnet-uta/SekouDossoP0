using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class Store
    {
        public Store()
        {
            Products = new HashSet<Product>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int? LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
