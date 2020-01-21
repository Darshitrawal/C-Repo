using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1: - ");
            PatternOne();
            Console.WriteLine(" ");
            Console.WriteLine("Pattern 2: - ");
            PatternTwo();
            Console.WriteLine(" ");
            Console.WriteLine("Pattern 3: - ");
            PatternThree();
            Console.WriteLine(" ");
            Console.WriteLine("Pattern 4: - ");
            PatternFour();
            Console.WriteLine(" ");
            Console.Read();
        }

        private static void PatternFour()
        {
            int i, j, k;
            for (i = 0; i < 5; i++)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            for (i = 1; i <= 5; i++)
            {
                for (j = 2; j <= i+2; j++)
                {
                    Console.Write(" ");
                }
                for (k = 4; k >= i; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
        }

        private static void PatternThree()
        {
            int i, j, k;
            for (i = 0; i < 5; i++)
            {
                for (j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        private static void PatternTwo()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }

        private static void PatternOne()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
