using AlgoAllInOne.Algos.Array;
using AlgoAllInOne.Algos.Graphs;
using AlgoAllInOne.Algos.Helper;
using AlgoAllInOne.Algos.LinkedList;
using AlgoAllInOne.Algos.Stack_and_Queue;
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

            #region LinkedLists
            //var ll= trigger.LinkedList();
            //ll.print();
            #region remove duplicates
            //Wrapper.MethodCall<bool>(ll.removeDuplicatesOne);
            //ll.print();
            //Wrapper.MethodCall<bool>(ll.removeDuplicatesTwo);
            //ll.print();
            #endregion

            // Last KTh Element Element
            //int lastEl = Wrapper.MethodCall<int,int>(ll.KThLastElement, 5);
            //  trigger.SumList();

            // trigger.FindDuplicate();
            #endregion

            #region stack

            #endregion

            #region Graphs
            //Graph g = new Graph();
            //var node1 = Wrapper.MethodCall<GraphNode>(() => g.BFS(3));
            //var node2 = Wrapper.MethodCall<GraphNode>(() => g.FindByDFS(3));
            #endregion

            #region tree
            Tree tree = new Tree();
            //int[] a = { 1, 2, 3, 4, 5 };
            //tree.CreateTreeFrom(a);
            tree.insertIntoTree(10);
            tree.insertIntoTree(9);
            tree.insertIntoTree(8);
            tree.insertIntoTree(7);
            tree.insertIntoTree(5);
            tree.insertIntoTree(18);
            tree.insertIntoTree(17);
            tree.insertIntoTree(15);
            //     var dict = tree.GetListsFromTree();
            var b = tree.isBalancedTree();
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


        #region linkedlist
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

        public void FindDuplicate()
        {
            CLinkedList c = new CLinkedList();
            c.Insert(4);
            c.Insert(3);
            c.Insert(1);
            c.Insert(2);
            c.Insert(4);
            c.print();
            var node = FindALoop(c);
            if (node != c.GetRoot())
            {
                Console.WriteLine($"Faulty node is {node.Data}");
            }
            else
            {
                Console.WriteLine($"No faulty node in c");
            }
            CLinkedList c2 = new CLinkedList();
            c2.Insert(5);
            c2.Insert(1);
            c2.Insert(3);
            c2.Insert(4);
            c2.print();
            var node2 = FindALoop(c2);
            if (node2 != c2.GetRoot())
            {
                Console.WriteLine($"Faulty node is {node2.Data}");
            }
            else
            {
                Console.WriteLine($"No faulty node in c2");
            }
        }

        private int LinkedListToNumber(CLinkedList c)
        {

            var start = c.GetRoot();
            int dig = 0;
            int number = 0;
            while (true)
            {
                if (start.Data != 0)
                {
                    int mutl = (int)Math.Pow(10, dig);
                    number += (start.Data * mutl);
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
            while (n > 0)
            {
                int x = n % 10;
                c.Insert(x);
                n = n / 10;
            }
            return c;
        }

        private Node FindALoop(CLinkedList cLinkedList)
        {
            var root = cLinkedList.GetRoot();
            HashSet<int> hs = new HashSet<int>();
            if (root != null)
            {
                var pointer = root;
                while (pointer.next != null)
                {
                    if (found(ref hs, pointer.Data))
                    {
                        return pointer;
                    }
                    pointer = pointer.next;
                }
                if (found(ref hs, pointer.Data))
                {
                    return pointer;
                }

            }


            return cLinkedList.GetRoot();
        }

        private bool found(ref HashSet<int> hs, int data)
        {
            if (hs.Contains(data))
            {
                return true;
            }
            else
            {
                hs.Add(data);
                return false;
            }
        }
        #endregion
        #region stack
        public void StackMin()
        {
            CustomStack s = new CustomStack(10);
            s.printStack();
            s.GetMinimum();
            s.push(9);
            s.push(11);
            s.push(14);
            s.push(3);
            s.GetMinimum();
            s.pop();
            s.pop();
            s.push(3);
            s.push(3);
            s.GetMinimum();
            s.pop();
            s.printStack();
        }
        public void SetOfStacks()
        {
            SetOfStacks setOfStacks = new SetOfStacks(3);
            setOfStacks.push(10);
            setOfStacks.push(13);
            setOfStacks.push(9);
            setOfStacks.push(5);
            setOfStacks.push(11);
            setOfStacks.push(2);
            setOfStacks.push(4);
            setOfStacks.printListOfStacks();
            setOfStacks.pop();
            setOfStacks.pop();
            setOfStacks.pop();
            setOfStacks.printListOfStacks();
        }
        #endregion

    }
}
