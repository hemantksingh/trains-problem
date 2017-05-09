using System;
using System.Collections.Generic;
using System.Linq;
using TrainsProblem;

public class Input
{
    private string text;

    public Input(string text)
    {
        
        this.text = text;
    }

    internal IEnumerable<Route> parseRoutes()
    {
        var routes = new List<Route>();
            this.text.Split(',')
                .ToList()
                .ForEach(x =>
                {
                    var values = x.Trim().ToCharArray();
                    routes.Add(new Route(
                        values[0].ToString(), 
                        values[1].ToString(),
                        int.Parse(values[2].ToString()))
                    );
                });
            return routes;
    }
}