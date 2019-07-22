using System;

namespace SimpleCSharpApp
{
    class Program
    {
        /*   static void Main(string[] args)
           {
               // Display a simple message to the user.
               Console.WriteLine("****My first C# App****");
               Console.WriteLine("Hello World!");
               Console.WriteLine();

               // Waiting for a key to be pressed before shutting down
               Console.ReadLine();
           }
       */

        // Return -1 to throw errors
        /*   static int Main(string[] args)
           {
               // Display a simple message to the user.
               Console.WriteLine("****My first C# App****");
               Console.WriteLine("Hello World!");
               Console.WriteLine();

               // Waiting for a key to be pressed before shutting down
               Console.ReadLine();

               return -1;
           }
       */

    // Supplying command line arguments w/ VB using 3 methods for / foreach / Environment.getCommandLineArgs()
        static void Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("****My first C# App****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Meth 1   for
            /*
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Args: {0}", args[i]);
            */

            // Meth 2   foreach
            /*
            foreach (string arg in args)
                Console.WriteLine("Args: {0}", arg);
            */

            //Meth 3    .getCommandLineArgs
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach(string arg in theArgs)
                Console.WriteLine("Args: {0}", arg);

            /***************************************************/
            //Environment Class usage

            ShowEnvironmentDetails();

            void ShowEnvironmentDetails()
            {
                //Printing drives on this machines and other details
                foreach (string drive in Environment.GetLogicalDrives())
                    Console.WriteLine("Drive: {0}", drive);

                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("# of processors: {0}", Environment.ProcessorCount);
                Console.WriteLine(".NET Version: {0}", Environment.Version);
            }
        }
    }
}
