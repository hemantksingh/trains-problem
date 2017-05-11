using System;
using Xunit;
using TrainsProblem;
using System.IO;

namespace TrainsProblemTest
{
    public class ApplicationTest
    {
        private string expectedOutput = System.IO.File.ReadAllText("ExpectedOutput.txt");

        [Fact]
        public void RunsWithSpecifiedInputFile()
        {
            string output = string.Empty;
            Application.SendOutput(x => output = x);
            Application.Main(new [] {"Input.txt"});

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void RunsWithDefaultInputFile()
        {
            string output = string.Empty;
            Application.SendOutput(x => output = x);
            Application.Main(new [] {""});

            Assert.Equal(expectedOutput, output);
        }
    }
}
