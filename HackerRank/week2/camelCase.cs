class Result
{

    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int camelcase(string s)
    {
        int result = 1; 
        
        if (s.Length < 1) result = 0; 
        foreach(var c in s.ToCharArray()){
            if (c != char.ToLower(c)) result += 1;
        }
        
        return result; 

    }

}
