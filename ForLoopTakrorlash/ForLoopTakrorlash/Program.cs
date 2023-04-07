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
            Console.Write("Enter number of row : ");
            int row = int.Parse(Console.ReadLine());

            for(int i = 1; i <= row;i++)
            {        
                for(int j = 1; j <= row - i;j++)
                {                   
                        Console.Write(j + " ");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
