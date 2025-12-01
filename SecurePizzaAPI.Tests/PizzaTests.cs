using System;
using System.Collections.Generic;
using System.Text;

using SecurePizzaAPI;
using Xunit;

namespace SecurePizzaAPI.Tests
{
    public class PizzaTests
    {
        [Fact]
        public void CanCreatePizza()
        {
            var p = new Pizza { Name = "Margherita" };
            Assert.Equal("Margherita", p.Name);
        }
    }
}
