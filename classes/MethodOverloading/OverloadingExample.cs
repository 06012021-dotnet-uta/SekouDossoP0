using System;

class OverloadingExample
{
    static void F(){ Console.WriteLine( "F()" ); }
    static void F(object x ){ Console.WriteLine( "F(object)" ); }
    static void F(int x ){ Console.WriteLine( "F(int)" ); }
    static void F(double x ){ Console.WriteLine( "F(double)" ); }
    static void F<T>(T x ){ Console.WriteLine( "F<T>(T)" ); }
    static void F(double x, double y ){ Console.WriteLine( "F(double, double)" ); }

    public static void UsageExample(){ 
        F(); // Invoke F()
        F(1); // Invoke F(int)
        F(1.0); // Invoke F(double)
        F("abc"); // Invoke F<string>(string)
        F((double)1); // Invoke F(double)
        F((object)1); // Invoke F(object)
        F<int>(1); // Invoke F<int>(int)
        F(1, 1); // Invoke F(double, double)
    }

}