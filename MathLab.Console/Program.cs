using MathLab.Domain.MathContext.Calculations;
using MathLab.Domain.MathContext.Context;
using System;
using System.Linq;

namespace MathLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            var number = int.Parse(Console.ReadLine());

            MathContext mathContext = new MathContext(new DividingNumberStrategy());
            var divisors = string.Join(" ", mathContext.GetNumbers(number).Select(x => x.ToString()).ToArray());
            Console.WriteLine("Dividores: "+divisors);

            MathContext primeContext = new MathContext(new PrimeNumberStrategy());
            var primes = string.Join(" ", primeContext.GetNumbers(number).Select(x => x.ToString()).OrderBy(x=>x).ToArray());
            Console.WriteLine("Primos: " + primes);

            Console.ReadKey();
        }

    }
}
    

