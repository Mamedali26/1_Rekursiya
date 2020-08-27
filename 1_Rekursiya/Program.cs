using System;

namespace _1_Rekursiya
{
    class Program
    {
        static void Main(string[] args)
        {
            int basis = 2;
            int pow = 10;
            Console.WriteLine($"The total of summary of exponents with base {basis} equals {Power(basis, pow)}.");
        }

        static int Power(int num, int pow)
        {
            int mult = 1;
            for (int i = 1; i <= pow; i++)
            {
                mult *= num;
            }

            if (pow == 2)
            {
                return 4;
            }
            else
            {
                return mult + Power(num, pow - 1);
            }
        }


    }
}
