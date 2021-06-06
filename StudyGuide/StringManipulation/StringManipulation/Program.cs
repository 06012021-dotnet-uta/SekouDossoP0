using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
        //from string literal and string concatenation
         string fname, lname;
         fname = "Rowan";
         lname = "Atkinson";

         char []letters= { 'H', 'e', 'l', 'l','o' };
         string [] sarray={ "Hello", "From", "Tutorials", "Point" };

         string fullname = fname + lname;
         Console.WriteLine("Full Name: {0}", fullname);
         Console.WriteLine($"Full Name with out  {fullname}");
         Type fullNameGetType = fullname.GetType();
         Console.WriteLine($"Get typeof fullname : , {fullname.GetType()}");
         
         //by using string constructor { 'H', 'e', 'l', 'l','o' };
         string greetings = new string(letters);
         Console.WriteLine("Greetings: {0}", greetings);

         //methods returning string { "Hello", "From", "Tutorials", "Point" };
         string message = String.Join(" ", sarray);
         Console.WriteLine("Message: {0}", message);

         //formatting method to convert a value
         DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
         string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
         Console.WriteLine("Message: {0}", chat);

         // comparing String 
        string str1 = "This is test";
        string str2 = "This is text";

        if (String.Compare(str1, str2) == 0) { // Using Compare method

            Console.WriteLine(str1 + " and " + str2 +  " are equal.");

        } else {

            Console.WriteLine(str1 + " and " + str2 + " are not equal.");

        }
        str1 = "This  ";
        str2 = "This  ";

        if (String.Compare(str1, str2) == 0) { // Using Compare method

            Console.WriteLine(str1 + " and " + str2 +  " are equal.");

        } else {

            Console.WriteLine(str1 + " and " + str2 + " are not equal.");

        }

        // string comparison return 0 if they are equal and 1 if they are not
        str1 = "Yes";
        str2 = "yes";
            Console.WriteLine($"{str1} and {str2} comparison return : { String.Compare(str1, str2) }.");

        

        // String Contains String
        string str = "This is test";
        if (str.Contains("test")) { // Using the Contains method
            Console.WriteLine("The sequence 'test' was found.");
        }

        //Getting a Substring
        str = "Last night I dreamt of San Pedro";
        Console.WriteLine(str);
        string substr = str.Substring(23); // Using the Substring method
        Console.WriteLine($" subString 23 : {substr}");

        // Join Strings

        string[] starray = new string[]{"Down the way nights are dark",

            "And the sun shines daily on the mountain top",

            "I took a trip on a sailing ship",

            "And when I reached Jamaica",

            "I made a stop"};


        str = String.Join("\n", starray); // Using the Join method

         Console.WriteLine($" starray after join: {str}");

      
        }
    }
}
