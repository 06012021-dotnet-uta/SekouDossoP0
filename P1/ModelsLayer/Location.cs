using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Location
    {
        public string LocationName { get; set; }
        public string City { get; set; }
        public string LocationState { get; set; }
        public int ZipCode { set; get; }

        // constructor
        public Location(string locationName, string city, string locationState, int zipCode)
        {
            this.LocationName = locationName;
            this.City = city;
            this.LocationState = locationState;
            this.ZipCode = zipCode;
        }
    }
}
