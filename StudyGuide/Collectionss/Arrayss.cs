using System;
using System.Collections;
namespace Collectionss
{
    public class Arrayss
    {
        // Arrays in C#?
        /*
            Arrays in C#?
            An array stores a fixed-size sequential collection of elements 
            of the same type. An array is used to store a collection of data, 
            but it is often more useful to think of an array as a collection 
            of variables of the same type stored at contiguous memory locations. 

            All arrays consist of contiguous memory locations. The lowest address 
            corresponds to the first element and the highest address to the last element. 
        */

        /*
            Declaring Arrays
                To declare an array in C#, you can use the following syntax :
                datatype[] arrayName;
        */

        // Initializing Arrays        
        // Array is a reference type, so you need to use the new keyword 
        // to create an instance of the array.
        
        // double[] balance = new double[10];
        // balance[0] = 4500.0;  //Assigning Values to an Array
        // You can assign values to the array at the time of declaration, as shown 
            // double[] balance = { 2340.0, 4523.69, 3421.0};

        // You can also create and initialize an array, as shown 
            // int [] marks = new int[5]  { 99,  98, 92, 97, 95};

        // You may also omit the size of the array, as shown 
            // int [] marks = new int[]  { 99,  98, 92, 97, 95};
    }
}