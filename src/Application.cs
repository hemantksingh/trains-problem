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
            var graph = new Graph(routes);

            Output (() => graph.CalculateDistance("A", "B", "C"));
            Output (() => graph.CalculateDistance("A", "D"));            
            Output (() => graph.CalculateDistance("A", "D", "C"));
            Output (() => graph.CalculateDistance("A", "E", "B", "C", "D"));
            Output (() => graph.CalculateDistance("A", "E", "D"));
        }

        private static void Output(Func<int> action) {
            try {
                 Console.WriteLine("Output: " + action());
            }catch(Exception e) {
                Console.WriteLine("Output:" + e.Message);
            }
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
