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
        }
    }
}
