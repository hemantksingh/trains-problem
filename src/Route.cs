namespace TrainsProblem
{
    public class Route
    {
        public readonly string From;
        public readonly string To;
        public readonly int Distance;
        
        public Route(string from, string to, int distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
    }
}
