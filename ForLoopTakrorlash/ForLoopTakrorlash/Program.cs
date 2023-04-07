using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTakrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number size of Romb : ");
            int m = int.Parse(Console.ReadLine());
            int n = (m / 2) + 1;

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i;j++)
                {
                    Console.Write(" ");
                }

                for(int  k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }

            for(int i = n - 1; i >= 1;i--)
            {
                for(int j = 1; j <= n - i;j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1;k <= i;k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine() ;
            }

            Console.ReadLine();
        }
    }
}
