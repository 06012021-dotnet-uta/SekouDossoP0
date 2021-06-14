using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Order>();
            Stores = new HashSet<Store>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string City { get; set; }
        public string LocationState { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
