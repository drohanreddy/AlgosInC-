using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.LinkedList
{
    public class CLinkedList
    {
        Node root;
        public CLinkedList()
        {
            root = null;
        }
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = data;
                root.next = null;

            }
            else
            {
                Node i = root;
                while (i.next != null)
                {
                    i = i.next;
                }
                Node t = new Node();
                t.Data = data;
                t.next = null;
                i.next = t;
            }
        }
        public void print()
        {
            if (root != null)
            {
                Node i = root;
                while (i.next != null)
                {
                    Console.Write($"{i.Data} -> ");
                    i = i.next;
                }
                Console.WriteLine(i.Data);
            }
            else
            {
                Console.WriteLine("List empty");
            }
        }

        public bool removeDuplicatesOne()
        {
            if (root != null)
            {
                var start = root;
                while (start.next != null)
                {
                    var i = start.next;
                    var j = start;
                    while(i.next != null)
                    {
                        if (i.Data == start.Data)
                        {
                            removeNode(j, i);
                            i = j.next;
                        }
                        else
                        {
                            j = i;
                            i = i.next;
                        }
                    }
                    if (i.Data == start.Data)
                    {
                        removeNode(j, i);
                    }
                    start = start.next;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Linked list is empty");
                return false;
            }
        }

        public bool removeDuplicatesTwo()
        {
            Dictionary<int, bool> log = new Dictionary<int, bool>();
            if (root != null)
            {
                var start = root;
                log.Add(start.Data, true);
                while (start.next != null)
                {                    
                    var i = start.next;
                    var j = start;
                    if (log.ContainsKey(i.Data))
                    {
                        removeNode(j, i);
                    }
                    if (start.next != null)
                    {
                        start = start.next;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        private void removeNode(Node prev, Node Current)
        {
            if (Current.next != null)
            {
                prev.next = Current.next;
            }
            else
            {
                prev.next = null;
            }
        }

        public int KThLastElement(int k)
        {
            int hop = 0;
            Node l = root;
            Node x = root;
            while (l.next != null)
            {
                l = l.next;
                hop++;
                if (hop>=k)
                {
                    x = x.next;
                }
            }
            if (x==root)
            {
                return -1;
            }
            return x.Data;

        }

        public Node GetRoot()
        {
            return root;
        }

    }
}