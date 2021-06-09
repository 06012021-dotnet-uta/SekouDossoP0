using System;
using System.Collections;
using System.Collections.Generic;
namespace P0
{
    public class StoreBase
    {
        // instance vars
        string location;
        string storeName;
        // static inventory; // really need more explaintion

        // constructor
        public StoreBase(string location, string storeName ){
            this.location = location;
            this.storeName = storeName; 
        }

        // instance methods
        public string Location{
            get{ return location;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("location title should be atleast 1 character.");
                }
                location = value;
            }
        }
        public string StoreName{
            get{ return storeName;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("store name should be atleast 1 character and less than 15 characters.");
                }
                storeName = value;
            }
        }
        
        // class methode
        
    }
}