using System;

namespace expressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from user 
            Console.WriteLine("Please enter a word: ");
            string input = Console.ReadLine();
            
            string s = "Revature "; 
            // SwitchStatement(s);
            SwitchStatement("Revature ");
            // IfStatement 
            IfStatement("Revature");
            // ForEachStatement
            ForEachStatement("Revature");
            // WithStatement 
            WhileStatement("Revature");
            // DoStatement 
            DoStatement("Revature");
            // ForStatement(string arg) 
            ForStatement(input);
            // BreakStatement(string arg) 
            BreakStatement(input);

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

        static void WhileStatement(string arg){
            int n = arg.Length;
            int count = 0;
            Console.WriteLine(" while statement");
            while(count < n ){
                Console.WriteLine($" {arg[count]}");
                count++;
            }
        }

        static void DoStatement(string arg){
            int n = arg.Length;
            int count = 0;
            Console.WriteLine(" Do statement");
            do{
                Console.WriteLine($" {arg[count]}");
                count++;
            }while(count < n );
        }

        static void ForStatement(string arg){
            int n = arg.Length;
            Console.WriteLine(" For statement");
            for(int i = 0; i<n; i++){
                Console.WriteLine($" {arg[i]}"); 
            }
        }

        static void BreakStatement(string arg){
            Console.WriteLine(" Please enter a word or press enter to exit");
            while (true){
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s)){
                    break;
                }
                Console.WriteLine(s);
            }
        }

    }
}
