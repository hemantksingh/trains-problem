using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TrainsProblem
{
    public class Application
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify an input file.");
                return;
            }
            
            IEnumerable<Route> routes = new Input(GetInput(args[0])).parseRoutes();
            Console.WriteLine($"No of routes: {routes.Count()}");
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
