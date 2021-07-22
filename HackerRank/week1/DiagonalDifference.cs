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

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count, ltr = 0,  rtl = 0 ;
        for(int i = 0 ; i<n ; i++){
            int current = arr[i][i];
            ltr += arr[i][i];
            rtl += arr[n-1-i][i];
        }
        return Math.Abs(ltr - rtl);
    }

}
