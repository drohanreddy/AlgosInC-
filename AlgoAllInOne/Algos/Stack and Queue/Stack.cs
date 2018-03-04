using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Stack_and_Queue
{
    public class CustomStack
    {
        public StackNode top { get; set; }
        public StackNode minimum { get; set; }
        public CustomStack(int data)
        {
            StackNode n = new StackNode(data);
            n.Size = 1;
            top = n;
            minimum = n;
        }

        public void push(int data)
        {
            StackNode node = new StackNode(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                if (data <= minimum.Data)
                {
                    var newMinimum = new StackNode(data);
                    var oldMinimum = minimum;
                    minimum = newMinimum;
                    minimum.next = oldMinimum;

                }
                node.next = top;
                node.Size = top.Size + 1;
                top = node;

            }
        }
        public void pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                Console.WriteLine("popped item is --" + top.Data);
                if (top.Data == minimum.Data)
                {
                    minimum = minimum.next;
                }
                top = top.next;
            }
        }
        public void GetMinimum()
        {
            if (top != null)
            {
                Console.WriteLine("minimum is " + minimum.Data);
            }

        }
        public void printStack()
        {
            Console.WriteLine("***Print Starts***");
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                var pointer = top;
                while (pointer.next != null)
                {
                    Console.WriteLine(pointer.Data);
                    pointer = pointer.next;
                }
                Console.WriteLine(pointer.Data);
            }
            Console.WriteLine("***Print Ends***");
        }
    }
    public class StackNode
    {
        public int Data { get; set; }
        public StackNode next { get; set; }
        public int Size { get; set; }
        public StackNode(int data)
        {
            this.Data = data;
            this.next = null;
            this.Size = 0;
        }
    }

    public class SetOfStacks
    {
        public int Threshold { get; set; }
        List<CustomStack> listOfStacks { get; set; }
        public SetOfStacks(int threshold)
        {
            this.Threshold = threshold;
            listOfStacks = null;
        }
        public void push(int data)
        {
            if (listOfStacks == null && listOfStacks.Count > 0)
            {
                CustomStack s = new CustomStack(data);
                listOfStacks = new List<CustomStack>();
                listOfStacks.Add(s);
            }
            else
            {
                bool stackFound = false;
                var lastStack = listOfStacks[listOfStacks.Count - 1];
                var top = lastStack.top;
                if (lastStack.top.Size < this.Threshold)
                {
                    lastStack.push(data);
                }
                else
                {
                    listOfStacks.Add(new CustomStack(data));
                }
            }
        }
        public void pop()
        {
            if (listOfStacks != null)
            {
                var lastStack = listOfStacks[listOfStacks.Count - 1];
                lastStack.top.Size = lastStack.top.Size - 1;
               
                
                if (lastStack.top.Size<1)
                {
                    listOfStacks.Remove(lastStack);
                }
                else
                {
                    lastStack.top = lastStack.top.next;
                }
            }
        }
        public void printListOfStacks()
        {
            foreach (var item in this.listOfStacks)
            {
                item.printStack();
            }
        }
    }
}
