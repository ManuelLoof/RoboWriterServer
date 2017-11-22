using Xunit;
using RoboWriter.Controllers;
using System.Collections.Generic;

namespace RoboWriterTest
{
    public class ValuesControllerTest
    {
        [Fact]
        public void TestValues()
        {
            var values = new ExampleController();
            var result = new List<string>(values.Get());
            Assert.True(result.Count == 2);     
        }
    }
}