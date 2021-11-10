using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var controller = new ValuesController();
            var returnValue = controller.Get(1);
            Assert.Equal("Les Jackson", returnValue.Value);
        }
    }
}