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
                Console.WriteLine("popped item is --"+top.Data);
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
                Console.WriteLine("minimum is "+minimum.Data);
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
        public StackNode(int data)
        {
            this.Data = data;
            this.next = null;
        }
    }
}
