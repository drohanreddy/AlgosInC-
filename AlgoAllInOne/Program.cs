using AlgoAllInOne.Algos.Array;
using AlgoAllInOne.Algos.Helper;
using AlgoAllInOne.Algos.LinkedList;
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
            // bool palindrome = Strings.palindromePermution("Tact Coa");
            //bool res = Strings.OneAway("pal", "pale");
            //string cmrs = Strings.Compress("aabbbbcdddd");
            var ll= trigger.LinkedList();
            Wrapper.MethodCall<bool>(ll.removeDuplicatesOne);
            ll.print();
            Wrapper.MethodCall<bool>(ll.removeDuplicatesTwo);
            ll.print();
            
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

        public CLinkedList LinkedList()
        {
            CLinkedList c = new CLinkedList();
            c.Insert(4);
            c.Insert(3);
            c.Insert(4);
            c.Insert(2);
            c.Insert(1);
            c.Insert(4);
            c.print();
            return c;

        }
    }
}
