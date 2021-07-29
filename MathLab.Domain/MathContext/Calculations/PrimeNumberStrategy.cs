using MathLab.Domain.MathContext.Context;
using MathLab.Domain.MathContext.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathLab.Domain.MathContext.Calculations
{
    public class PrimeNumberStrategy : ICalculation
    {
        public IList<int> GetNumbers(int number)
        {
            int count = 0;
            int[] vector = new int[number];
            int[]  arrayResult = new int[number];
            int i = 0;
            int index = 0;
            for (i = 2; i <= number; i++)
            {
                if (MathExtension.IsPrime(i) == true)
                    vector[count++] = i;
            }
            while (true)
            {
                if (MathExtension.IsPrime(number) == true)
                {
                    arrayResult[index++] = number;
                    break;
                }
                for (i = count - 1; i >= 0; i--)
                {
                    if ((number % vector[i]) == 0)
                    {
                        arrayResult[index++] = vector[i];
                        number = number / vector[i];
                        break;
                    }
                }
            }
            arrayResult[index] = 1;
            return arrayResult.Where(x=>x>0).Distinct().ToList();
        }
    }
}
