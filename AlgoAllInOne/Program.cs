using AlgoAllInOne.Algos.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum calculator = new TwoSum(new int[]{ 2, 3, 4, 5, 7, 1, 12, 15, 6 }, 20);
            int[] output = calculator.basicMethod();
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
        }
    }
}
