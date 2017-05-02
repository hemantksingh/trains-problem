using System;
using System.IO;
using System.Linq;

namespace trains_problem
{
    public class Application
    {
        private static string defaultInputFile = "Input.txt";

        public static void Main(string[] args)
        {
            string input = GetInput(args[0]);
            Console.WriteLine($"Input: {input}");
        }

        private static string GetInput(string inputFile) {
            if(!String.IsNullOrWhiteSpace(inputFile))
            {
                if(File.Exists(inputFile))
                    return File.ReadAllText(inputFile);
                else
                    Console.WriteLine($"Cannot find the input file '{inputFile}'");
            }

            Console.WriteLine($"Using the default input file '{defaultInputFile}'");
            return File.ReadAllText(defaultInputFile);
        }
    }
}
