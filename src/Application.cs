using System;
using System.IO;
using System.Linq;

namespace TrainsProblem
{
    public class Application
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Please specify an input file.");
                return;
            }
            string input = GetInput(args[0]);
            Console.WriteLine($"Input: {input}");
        }

        private static string GetInput(string inputFile)
        {
            const string defaultInputFile = "Input.txt";
            if (!String.IsNullOrWhiteSpace(inputFile))
            {
                if (File.Exists(inputFile))
                    return File.ReadAllText(inputFile);
                else
                    Console.WriteLine($"Cannot find the input file '{inputFile}'");
            }

            Console.WriteLine($"Using the default input file '{defaultInputFile}'");
            return File.ReadAllText(defaultInputFile);
        }
    }
}
