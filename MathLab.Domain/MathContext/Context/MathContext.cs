
using System.Collections.Generic;


namespace MathLab.Domain.MathContext.Context
{
    public class MathContext
    {
        private ICalculation calculation;
        public MathContext(ICalculation calculation)
        {
            this.calculation = calculation;
        }

        public IList<int> GetNumbers(int number)
        {
            return this.calculation.GetNumbers(number);
        }
    }
}
