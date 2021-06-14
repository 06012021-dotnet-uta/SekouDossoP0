using System;
namespace P0
{
    public class Location
    {
        // class var 
        // instance var 
        string locationName;
        string city;
        string locationState;
        int zipCode;

        // constructor
        public Location(string locationName, string city, string locationState, int zipCode){
            this.locationName = locationName;
            this.city = city;
            this.LocationState = locationState;
            this.zipCode = zipCode;
        }
        // instance methods 
        public string LocationName{
            get{ return locationName;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("locationName should be atleast 1 character.");
                }
                locationName = value;
            }
        }
        public string City{
            get{ return city;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("city should be atleast 1 character.");
                }
                city = value;
            }
        }
        public string LocationState {
            get{ return locationState;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("locationState should be atleast 1 character.");
                }
                locationState = value;
            }
        }
        public int ZipCode{
            get{ return zipCode;}
            set{
                while(value < 1 ){
                    throw new InvalidOperationException ("zipCode should be atleast 1 character.");
                }
                zipCode = value;
            }
        }
       
    }
}