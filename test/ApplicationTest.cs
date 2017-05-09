using System;
using Xunit;
using TrainsProblem;

namespace TrainsProblemTest
{
    public class ApplicationTest
    {
        [Fact]
        public void RunsWithSpecifiedInputFile()
        {
            string expectedOutput = System.IO.File.ReadAllText("ExpectedOutput.txt");
            Application.Main(new [] {"Input.txt"});
        }

        [Fact]
        public void RunsWithDefaultInputFile()
        {
            string expectedOutput = System.IO.File.ReadAllText("ExpectedOutput.txt");
            Application.Main(new [] {""});
        }
    }
}
