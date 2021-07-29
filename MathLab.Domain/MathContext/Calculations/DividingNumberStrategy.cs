using MathLab.Domain.MathContext.Context;
using System;
using System.Collections.Generic;


namespace MathLab.Domain.MathContext.Calculations
{
    public class DividingNumberStrategy : ICalculation
    {
        public IList<int> GetNumbers(int number)
        {
            List<int> numbers = new List<int>();
            for (var i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }
}
