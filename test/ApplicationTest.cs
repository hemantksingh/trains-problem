using System;
using Xunit;
using trains_problem;

namespace test
{
    public class ApplicationTest
    {
        [Fact]
        public void WritesHelloWorld()
        {
            Application.Main(new [] {""});
        }
    }
}
