using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TrainsProblem
{
    public class Application
    {
        private static Action<string> sendOutput =  Console.WriteLine;

        private Application(Action<string> action)
        {
            sendOutput = action;
        }

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify an input file.");
                return;
            }

            IEnumerable<Route> routes =new Input(args[0]).ParseRoutes();
            var graph = new Graph(routes);

            var builder = new StringBuilder();
            builder.AppendLine("Output #1: " + ResultOf(() => graph.CalculateDistance("A", "B", "C")));
            builder.AppendLine("Output #2: " + ResultOf(() => graph.CalculateDistance("A", "D")));
            builder.AppendLine("Output #3: " + ResultOf(() => graph.CalculateDistance("A", "D", "C")));
            builder.AppendLine("Output #4: " + ResultOf(() => graph.CalculateDistance("A", "E", "B", "C", "D")));
            builder.AppendLine("Output #5: " + ResultOf(() => graph.CalculateDistance("A", "E", "D")));
            

            sendOutput(builder.ToString());
        }

        public static Application SendOutput(Action<string> action)
        {
            return new Application(action);
        }

        private static string ResultOf<T>(Func<T> action) {
            try {
                 return action().ToString();
            }catch(Exception e) {
                // log exception
                return e.Message;
            }
        }
    }
}
