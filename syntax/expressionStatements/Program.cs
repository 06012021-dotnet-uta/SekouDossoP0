using System;

namespace expressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = "Revature "; 
            // SwitchStatement(s);
            SwitchStatement("Revature ");
            // IfStatement 
            IfStatement("Revature");
            // ForEachStatement
            ForEachStatement("Revature");
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

        static void IfStatement(string arg){
            int n = arg.Length;
            if(n > 0){
                Console.WriteLine($" This argument length is {n}");
            }
            else{
                Console.WriteLine(" no argument ");
            }
        }

        static void ForEachStatement(string arg){
            foreach(char c in arg){
                Console.WriteLine($" {c}");
            }
        }

    }
}
