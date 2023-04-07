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

            Console.Write("Array enter ");
            string input = Console.ReadLine();
            int array;
            bool check = int.TryParse(input, out array);
            int[] arr = new int[array];


            Random random = new Random();
            for(int i = 0; i < arr.Length;i++)
            {
                int k = random.Next(1,10);
                Console.Write(k + " ");
                arr[i] = k;
            }
            Console.WriteLine();


            Array.Sort(arr);

            Console.WriteLine("Array o`sish tartibida : ");

            foreach (int num in arr) 
            {
                Console.Write(num + ", ");
            }

            Console.ReadLine(); 
        }
    }
}
