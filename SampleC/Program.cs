using System;

namespace SampleC
{
    class Program
    {
        static void Main(string[] args)
        {
            NewingDataType();
            ObjectFunctionality();
            CharFunctionality();
            ParseFromString();
        }

        static void NewingDataType()
        {
            Console.WriteLine("=> Using new to create a default data type:");

            bool b = new bool();                    //set to false
            int i = new int();                      //set to 0
            double d = new double();                //set to 0
            DateTime dt = new DateTime();           //set to 01/01/0001 00:00:00
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();

        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:   type a number:");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}.getHashCode() = {1}", i, i.GetHashCode());
            Console.WriteLine("{0}.Equals(148) = {1}", i, i.Equals(148));
            Console.WriteLine("{0}.ToString() = {1}", i, i.ToString());
            Console.WriteLine("{0}.getType() = {1}", i, i.GetType());
            Console.WriteLine();


        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> CharType functionality");

            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a') : {0}", myChar);
            Console.WriteLine("char.IsLetter('a') : {0}", myChar);
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6) : {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5) : {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsPunctuation('?') : {0}", char.IsWhiteSpace('?'));
            Console.WriteLine();

        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data Type parsing from string");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("941.52");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("423");
            Console.WriteLine("Value of i: {0}", i);

            Console.WriteLine();

        }

    }
}