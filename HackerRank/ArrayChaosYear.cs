 public static void minimumBribes(List<int> q)
    {
        int result = 0; 
        for (int i = 0 ; i < q.Count; i++ )
        {
            if( ( q[i] - (i+1) ) > 2 ) {
                Console.WriteLine("Too chaotic");
                return;
            }
        }
            
        for (int i = 0 ; i < q.Count; i++ )
        {
            for(int j =i+1 ; j < q.Count; j++){
                
                if(q[i]>q[j]){ 
                    int temp = q[j];
                    q[j] = q[i];
                    q[i] = temp; 
                    result += 1;
                }
            }
        }
        Console.WriteLine(result) ;
    }
