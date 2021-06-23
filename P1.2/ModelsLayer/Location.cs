using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Location
    {
        [key]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Location Name must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Location Name ")]
        public string LocationName { get; set; }

        [Required(ErrorMessage = "City must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "City ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Location State must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Location State ")]
        public string LocationState { get; set; }

        [Required(ErrorMessage = "ZipCode must be at least 1 character.")]
        [Display(Name = "ZipCode ")]
        public int ZipCode { set; get; }

        // constructor
        public Location(){
            LocationName = "locationName";
            City = "city";
            LocationState = "locationState";
            ZipCode = 111;
        }
        public Location(string locationName, string city, string locationState, int zipCode)
        {
            this.LocationName = locationName;
            this.City = city;
            this.LocationState = locationState;
            this.ZipCode = zipCode;
        }
    }
}
