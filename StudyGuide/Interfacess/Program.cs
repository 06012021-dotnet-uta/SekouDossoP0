using System;

namespace Interfacess
{
    class Program
    {
        /*
            Interface?
            An interface is defined as a syntactical contract that all 
                the classes inheriting the interface should follow. 
                The interface defines the 'what' part of the syntactical contract and 
                the deriving classes define the 'how' part of the syntactical contract.
            Interfaces define properties, methods, and events, which are the 
                members of the interface. Interfaces contain only the declaration of 
                the members. It is the responsibility of the deriving class to define 
                the members. It often helps in providing a standard structure that the 
                deriving classes would follow.
            Abstract classes to some extent serve the same purpose, however, 
            they are mostly used when only few methods are to be declared by the 
            base class and the deriving class implements the functionalities.
    */
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.WriteLine($"get t1 amount : {t1.getAmount()}");

        }
    }
}
