using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    class Store
    {
        // instance methods
        public string StoreName { get; set; }
        public Location Location { get; set;}
        // constructor
        public Store(string storeName, Location location)
        {
            this.StoreName = storeName;
            this.Location = location;
        }
    }
}
