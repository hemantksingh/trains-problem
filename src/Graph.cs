using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainsProblem
{
    internal class Graph
    {
        private readonly Dictionary<string, Dictionary<string, int>> _graph;

        public Graph(IEnumerable<Route> routes)
        {
            _graph = routes.GroupBy(x => x.From)
                .ToDictionary(x => x.Key, 
                    x => x.ToDictionary(y => y.To, y => y.Distance));
        }

        internal int CalculateDistance(params string[] route)
        {
            int totalDistance = 0;
            
            for(int i = 0; i < route.Length -1; i++) {
                var from = route[i];
                var to = route[i + 1];
                var destination = new Dictionary<string, int>();

                if (_graph.TryGetValue(from, out destination)) {
                    int distance;
                    if (destination.TryGetValue(to, out distance))
                        totalDistance += distance;
                    else {
                        string r = string.Join("->", route);
                        throw new ArgumentException($"'{r}' NO SUCH ROUTE");
                    }
                }
            }

            return totalDistance;
        }
    }
}