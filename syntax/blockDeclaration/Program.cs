using System;

namespace blockDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            Declarations();
            ConstantDeclarations();
            Expression();
        }

        static void Declarations(){
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine($"sum of a+b+c = {a+b+c}");
        }

        static void ConstantDeclarations(){
            const float pi = 3.141f;
            const int r = 25;
            Console.WriteLine($"circle surface formula pi*r*r = {pi*r*r}");
        }

        static void Expression(){
            int i;
            i = 123;
            Console.WriteLine($"this is i: {i}");
            i++;
            Console.WriteLine($"this is i++: {i}"); // increment i before read it  
            ++i;
            Console.WriteLine($"this is ++i: {i}"); //  increment i before read it   



        }


    }
}
