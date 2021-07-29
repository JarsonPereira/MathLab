using MathLab.Domain.MathContext.Calculations;
using MathLab.Domain.MathContext.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MathLab.Test
{

    public class PrimeTest
    {
        [Theory]
        [InlineData(45)]
        public void NumberShowPrimes(int number)
        {
            var divisors45 = new List<int>();
            divisors45.AddRange(new[] { 1, 3, 5 });

            MathContext mathContext = new MathContext(new PrimeNumberStrategy());
            var divisors = mathContext.GetNumbers(number).ToList();
                Assert.Equal(divisors, divisors45);
        }
    }
}
