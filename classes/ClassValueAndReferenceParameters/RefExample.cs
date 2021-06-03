using System; 

class RefExample{
    // value parameters
    static void Divide(int x , int y){
        var result = x/y;
        var remainder = x%y; 
    }

    // reference parameters 
    static void Swap(ref int x , ref int y){
        int temp = x ;
        x = y; 
        y = temp ;
    }
    public static void SwapExample(){
        int i =1, j = 2 ;
        Swap(ref i, ref j);
        Console.WriteLine( $"i = {i} and j = {j}" );
    }
}