using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrainsProblem;

public class Input
{
    private readonly string _fileName;
    private readonly string _defaultInputFile = "Input.txt";

    public Input(string fileName)
    {
        _fileName = fileName;
    }

    internal IEnumerable<Route> ParseRoutes()
    {
        var routes = new List<Route>();
        GetInput(_fileName, _defaultInputFile)
            .Split(',')
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

    private static string GetInput(string inputFile, string defaultInputFile)
    {
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