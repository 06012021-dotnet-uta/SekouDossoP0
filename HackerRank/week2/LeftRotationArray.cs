public static List<int> rotLeft(List<int> a, int d)
    {
         
        for ( int i = 0; i < d; i++ ){
            int first = a[0];
            // List<int> result = a.slice(1);
            a.RemoveAt((0));
            a.Add(first); 
        }
        return a;
    }