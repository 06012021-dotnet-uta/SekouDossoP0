using System;

namespace expressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = "Revature"; 
            // SwitchStatement(s);
            SwitchStatement("Revature");
        }

        static void SwitchStatement(string arg){
            int n = arg.Length;
            switch (n){
                case 0:
                    Console.WriteLine("No argument");
                    break;
                case 1:
                    Console.WriteLine("1 argument");
                    break;
                case 2:
                    Console.WriteLine("2 arguments");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
    }
}
