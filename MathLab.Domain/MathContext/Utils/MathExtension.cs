using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLab.Domain.MathContext.Utils
{
    public static class MathExtension
    {
        public static bool IsPrime(int number)
        {
            bool prime = true;
            int factor = number / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((number % i) == 0)
                    prime = false;
            }
            return prime;
        }
    }
}
