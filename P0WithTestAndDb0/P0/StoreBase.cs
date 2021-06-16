using System;
using System.Collections;
using System.Collections.Generic;
namespace P0
{
    public class StoreBase
    {
        // instance vars
        string storeName;
        Location location;
        // static inventory; // really need more explaintion

        // constructor
        public StoreBase(string storeName, Location location ){
            this.storeName = storeName; 
            this.location = location;
           
        }

        // instance methods
        public Location Location{
            get{ return location;}
            set{location = value;}
        }
        public string StoreName{
            get{ return storeName;}
            set{
                // while(value.Length < 1 ){
                //     throw new InvalidOperationException ("store name should be atleast 1 character and less than 15 characters.");
                // }
                storeName = value;
            }
        }
        
        
        // class methode
        
    }
}