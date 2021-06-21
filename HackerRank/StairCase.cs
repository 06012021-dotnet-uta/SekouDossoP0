using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class StairCase
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */


    public static void Main(string[] args){

        staircase(6);
    }
    public static void staircase(int n)
    {
        for (int i = 1 ; i < n+1; i++){
            Console.WriteLine(string.Concat(Enumerable.Repeat($" ", n-i))+string.Concat(Enumerable.Repeat($"#", i)) );
        } 
    }
}
