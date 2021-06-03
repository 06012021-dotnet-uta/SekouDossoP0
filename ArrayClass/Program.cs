using System;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a single dimensional array  
            int[] a1 = new int[5]; 

            // declare and set element value 
            int[] a2 = new int[5] {1, 2, 3, 4, 5}; 

            // alternative syntax 
            int[] a3 = {1,2,3,4,5};

            // declare a two dimensional array  
            int[,] multiDimensionalArray1 = new int[2, 3]; 

             // declare and set element value in 2 dimensional array
            int[,] multiDimensionalArray2 = { {1, 2, 3}, {4, 5,6} }; 

            // declare a jagged array 
            int[][] jaggedArray = new int[6][];

            // set the values of the  first array in the jagged array structure 
            jaggedArray[0] = new int[4] {1, 2, 3, 4};
            

        }
    }
}
