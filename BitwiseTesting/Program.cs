using System;

namespace BitwiseTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            uint int1 = 0b_0000_0000_0000_0000_0000_0000_0000_0001;
            uint int2 = 0b_0000_0000_0000_0000_0000_0000_0000_0001;
            Console.WriteLine(int1);
            Console.WriteLine(Convert.ToString(int1, toBase: 2));
            int1 ^= int1;
            //intReverse = intReverse << 31;
            //int2 = ~intReverse;
            //intReverse = intReverse >> 32;
            Console.WriteLine(int1);
            Console.WriteLine(Convert.ToString(int1, toBase: 2));
        }
    }
}
