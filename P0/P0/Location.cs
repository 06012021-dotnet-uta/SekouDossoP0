using System;
namespace P0
{
    public class Location
    {
        // class var 
        // instance var 
        string locationName;
        string city;
        string state;
        int zipCode;

        // constructor
        public Location(string locationName, string city, string state, int zipCode){
            this.locationName = locationName;
            this.city = city;
            this.state = state;
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
        public string State {
            get{ return state;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("state should be atleast 1 character.");
                }
                state = value;
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
        // override methods
	  // interface methods
        // class methods


    }
}