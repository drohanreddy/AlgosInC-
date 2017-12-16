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
            #region string and arrays
            // trigger.calculateTwoSum();
            //  bool res =  Strings.isPermution("acefdb", "ffbacd");
            // string urlify = Strings.urlify("Mr John Smith    ", 13);
            // bool palindrome = Strings.palindromePermution("Tact Coa");
            //bool res = Strings.OneAway("pal", "pale");
            //string cmrs = Strings.Compress("aabbbbcdddd");
#endregion 
            var ll= trigger.LinkedList();
            ll.print();
            #region LinkedLists
            #region remove duplicates
            //Wrapper.MethodCall<bool>(ll.removeDuplicatesOne);
            //ll.print();
            //Wrapper.MethodCall<bool>(ll.removeDuplicatesTwo);
            //ll.print();
            #endregion

            // Last KTh Element Element
            //int lastEl = Wrapper.MethodCall<int,int>(ll.KThLastElement, 5);
            trigger.SumList();
            #endregion

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

        public void SumList()
        {
            CLinkedList c = new CLinkedList();
            c.Insert(4);
            c.Insert(3);
            c.Insert(1);
            CLinkedList c2 = new CLinkedList();
            c2.Insert(5);
            c2.Insert(5);
            c2.Insert(0);
            c2.Insert(5);
            var number = LinkedListToNumber(c);
            var second = LinkedListToNumber(c2);
            int sume = number + second;
            NumberLinkedLis(sume).print();

        }

        private int LinkedListToNumber(CLinkedList c)
        {

            var start = c.GetRoot();
            int dig = 0;
            int number = 0;
            while (true)
            {
                if (start.Data !=0)
                {
                    int mutl = (int)Math.Pow(10, dig);
                    number += (start.Data* mutl);
                }
                else
                {
                    number += 0;
                }
                dig++;
             
                if (start.next == null)
                {
                    break;
                }
                start = start.next;
            }
            return number;
        }

        private CLinkedList NumberLinkedLis(int number)
        {
            CLinkedList c = new CLinkedList();
            int n = number;
            while(n > 0)
            {
                int x = n % 10;
                c.Insert(x);
                n = n / 10;
            }
            return c;
        }
    }
}
