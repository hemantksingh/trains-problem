using System;
using Xunit;
using trains_problem;

namespace test
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
