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
            Triggers trigger = new Triggers();
            // trigger.calculateTwoSum();
            //  bool res =  Strings.isPermution("acefdb", "ffbacd");
            // string urlify = Strings.urlify("Mr John Smith    ", 13);
            bool palindrome = Strings.palindromePermution("Tact Coa");
        }

    }
    class Triggers
    {
        public void calculateTwoSum()
        {
            TwoSum calculator = new TwoSum(new int[] { 3, 2, 4 }, 6);
            // int[] output = calculator.basicMethod();
            int[] output = calculator.aBetterApproach();
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
        }
    }
}
