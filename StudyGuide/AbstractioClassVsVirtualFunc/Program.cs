using System;

namespace AbstractioClassVsVirtualFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract and Sealed Keywords
                /*The abstract keyword enables you to create classes and class members 
                 that are incomplete and must be implemented in a derived class. */

                /* The sealed keyword enables you to prevent the inheritance of a class or 
                   certain class members that were previously marked virtual.  */

            // Difference between Virtual Function and Abstract Method
                /*
                    An abstract function cannot have functionality. 
                    Any child class MUST give their own version of this method, 
                    however it's too general to even try to implement in the parent class. 
                */
                /*
                    A virtual function has the functionality that may or may not be good enough
                     for the child class. So if it is good enough, use this method, if not, 
                     then override it, and provide your own functionality.
                */


        }
    }
    // Classes can be declared as abstract by putting the keyword abstract before the class definition.
    // An abstract class cannot be instantiated.
    public abstract class A
    {
        // Class members here.
    }

    // Abstract classes may also define abstract methods.
    public abstract class AA
    {
        public abstract void DoWork(int i); //Abstract methods have no implementation

    }

    /*
        When an abstract class inherits a virtual method from a base class, 
        the abstract class can override the virtual method with an abstract method. 
    */
    public class D
    {        
        public virtual void DoWork(int i)
        {
            // Original implementation.
        }
    }
    public abstract class E : D
    {
        public abstract override void DoWork(int i); //Overriding a virtual method
    }
    public class F : E
    {
        public override void DoWork(int i)
        {
            // New implementation.
        }
    }

    /*
        If a virtual method is declared abstract, it is still virtual 
        to any class inheriting from the abstract class. A class inheriting 
        an abstract method cannot access the original implementation of the method
    */

    /*
        Virtual Functions 
        A virtual method is used to override specified base class implementation 
        when a runtime object is of the derived type. Thus, virtual methods 
        facilitate the consistent functionality of a related object set. 

    */
}
