using System.Numerics;

namespace WorkingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with large integers:");
            Console.WriteLine("-----------------------------------");

            ulong big = ulong.MaxValue;
            Console.WriteLine($"{big,40:N0}");

            BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"{bigger,40:N0}");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Working with Complex Numbers");

            Complex c1 = new(real: 4, imaginary: 2);
            Complex c2 = new(real: 3, imaginary: 7);
            Complex c3 = c1 + c2;

            Console.WriteLine($"{c1} + {c2} = {c3}");

            Console.WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
                c1.Real, c1.Imaginary,
                c2.Real, c2.Imaginary,
                c3.Real, c3.Imaginary);

        }
    }
}
