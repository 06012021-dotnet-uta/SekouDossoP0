using System;
using System.Collections;

namespace Collectionss {
    class Program
    {
        static void Main(string[] args)
        {
        //Array
            int []  n = new int[10]; /* n is an array of 10 integers */
            int i,j;

            /* initialize elements of array n */ 
            for ( i = 0; i < 10; i++ ) { //Setting the array with values from 100 to 109
                n[ i ] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++ ) { //Traversing through the array to display the values
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
        
        // ArrayList
        
            ArrayList arraylist = new ArrayList(); //Instantiating an ArrayList 
            Console.WriteLine("Adding some numbers:");
            arraylist.Add(45); //Adding elements into the ArrayList
            arraylist.Add(78);
            arraylist.Add(33);
            arraylist.Add(56);
            arraylist.Add(12);
            arraylist.Add(23);
            arraylist.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al) { //Traversing through an ArrayList
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort(); //Sorting an ArrayList
            foreach (int i in al) {  //Traversing through an ArrayList
                Console.Write(i + " ");
            }

            Console.WriteLine();

        // HASHTABLE a         
            Hashtable ht = new Hashtable(); //Instantiating a HashTable
            ht.Add("001", "Zara Ali"); //Adding elements into the HashTable
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali")) { //Checks if a value is in the HashTable
                Console.WriteLine("This student name is already in the list");
            } else {
                ht.Add("008", "Nuha Ali"); //If not adds the value to the HashTable
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys; //Get the keys alone
            foreach (string k in key) { //Traverse and display the keys & value
                Console.WriteLine(k + ": " + ht[k]);
            }
        
        // STACK 
            Stack st = new Stack(); //Instantiating a Stack
            st.Push('A'); //Pushing items to the top of the stack
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st) { //Traversing through the stack
                Console.Write(c + " ");
            }

            Console.WriteLine();
            st.Push('V'); //Adding more items to the stack {V,W,G,M,A} - current state
            st.Push('H'); //Adding more items to the stack {H,V,W,G,M,A} - current state
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st) { //Traversing through the stack
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Removing values ");
            st.Pop(); //Popping elements from the top of the stack {H}
            st.Pop(); //Popping elements from the top of the stack {V}
            st.Pop(); //Popping elements from the top of the stack {W}

            Console.WriteLine("Current stack: ");
            foreach (char c in st) { //Traversing through the stack {G,M,A}
                Console.Write(c + " ");
            }

        // QUEUE
            Queue q = new Queue(); //Instantiating a Queue
            q.Enqueue('A'); //Adding elements into a Queue
            q.Enqueue('M'); //Adding elements into a Queue
            q.Enqueue('G'); //Adding elements into a Queue
            q.Enqueue('W'); //Adding elements into a Queue {A,M,G,W} - current state

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " "); //Traversal using foreach loop

            Console.WriteLine();
            q.Enqueue('V'); //Adding elements into a Queue
            q.Enqueue('H'); //Adding elements into a Queue {A,M,G,W,V,H} - current state
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " "); //Traversal using foreach loop

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue(); //Removing elements from queue {A}
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue(); //Removing elements from queue {M}
            Console.WriteLine("The removed value: {0}", ch);

        }
    }
}
