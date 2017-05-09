namespace TrainsProblem
{
    public class Route
    {
        private string from;
        private string to;
        private int distance;
        
        public Route(string from, string to, int distance)
        {
            this.from = from;
            this.to = to;
            this.distance = distance;
        }
    }
}
