class Solution {

    // Complete the substrCount function below.
    // abcbaba
    static long substrCount(int n, string s) {
        long retVal = s.Length;
          for (int i = 0; i < s.Length; i++)
        {
            var startChar = s[i];  // start character 
            int diffCharIdx = -1;
            for (int j = i + 1; j < s.Length; j++)  // inner loop 
            {
                var currChar = s[j]; // set next character to s[j]
                if (startChar == currChar)
                {
                    if ((diffCharIdx == -1) ||
                       (j - diffCharIdx) == (diffCharIdx - i))
                        retVal++;
                }
                else
                {
                    if (diffCharIdx == -1)
                        diffCharIdx = j;
                    else
                        break;
                }
            }
        }
        return retVal;
    }

   
}