using System;

namespace structureExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Expressions are constructed from operands and operators .
                Operators are: + , - , * , / , new
                Operands are what the operators act upon: literals, fields, Local variables, expressions
                Precedence of the operators controls the order in which the individual operators are evaluated. (Basically PEMDAS)
            */

            var a = 2 + 2 * 2 ;
            Console.WriteLine($"This a var a {a}");
            // output => This a var a 6
        }
    }
}
