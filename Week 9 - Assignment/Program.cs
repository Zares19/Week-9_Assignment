using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week_9___Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                Console.WriteLine("Enter file path");
                string filePath = Console.ReadLine();
                StreamReader sr = new StreamReader(filePath);

                Console.WriteLine(sr.ReadToEnd());

               var pathFinder = new Regex(@"^\w{1}\W\W[A-Za-z)-9]+\.\w{3}$");

                if (pathFinder.IsMatch(filePath))
                {
                    Console.WriteLine("Valid file path");
                }
                else
                    Console.WriteLine("Invalid file path");

                
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read/found.");
                Console.WriteLine(e.GetType() + ": " + e.Message);
            }

        }
    }
}
