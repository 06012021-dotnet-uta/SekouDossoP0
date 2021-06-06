using System;
using System.Collections;
using System.Collections.Generic;

namespace ListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of string by using a collection initializer. 
            var salmons = new List<string> { "chinook", "coho", "pink"};
            // public List<string> salmons = new List<string>();
            // salmons.Add("chinook");
            // salmons.Add("coho");
            // salmons.Add("pink");
            salmons.Add("sockey");

            // remove an element from the list by specifying the object 
            salmons.Remove("coho");

            // iterate through the list
            foreach ( var salmon in salmons ){
                Console.WriteLine(salmon + " ");
            }

        }
    }
}
