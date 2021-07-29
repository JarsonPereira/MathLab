using MathLab.Domain.MathContext.Calculations;
using MathLab.Domain.MathContext.Context;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathLab.Test
{

   public  class DivisorTest
    {
        [Theory]
        [InlineData(45)]
        public void NumberShowDivisors(int number )
        {
            var prime45 =  new List<int>();
            prime45.AddRange(new[] { 1,3,5,9,15 });

            MathContext mathContext = new MathContext(new DividingNumberStrategy());
            var primes = mathContext.GetNumbers(number).ToList();
            Assert.Equal(primes, prime45);
        }
    }
}

