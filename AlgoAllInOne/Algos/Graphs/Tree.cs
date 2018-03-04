using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Graphs
{
    public class Tree
    {
        public TreeNode Root { get; set; }
        public Dictionary<int, LinkedList<TreeNode>> list { get; set; }
        public Tree CreateTreeFrom(int[] a)
        {
            var count = a.Length;
            if (count == 0)
            {
                return null;
            }
            addMiddleElement(0, count - 1, a);
            return this;

        }

        public void addMiddleElement(int start, int end, int[] a)
        {
            if (end < start)
            {
                return;
            }
            int middle = (start + end) / 2;
            insertIntoTree(a[middle]);
            addMiddleElement(start, middle - 1, a);
            addMiddleElement(middle + 1, end, a);
        }

        public void insertIntoTree(int data)
        {
            if (this.Root == null)
            {
                this.Root = new TreeNode(data);

            }
            else
            {
                var node = this.Root;
                while (true)
                {
                    if (data < node.Value)
                    {
                        if (node.Left == null)
                        {
                            var n = new TreeNode(data);
                            node.Left = n;
                            break;
                        }
                        else
                        {
                            node = node.Left;
                        }
                    }
                    if (data >= node.Value)
                    {
                        if (node.Right == null)
                        {
                            var n = new TreeNode(data);
                            node.Right = n;
                            break;
                        }
                        else
                        {
                            node = node.Right;
                        }
                    }
                }

            }
        }

        public bool isBST()
        {
            try
            {
                isBSTNode(this.Root);
            }
            catch (Exception ex)
            {

                if (ex.Message == "400")
                {
                    return false;
                }
            }
            return true;
        }

        private void isBSTNode(TreeNode treeNode)
        {
            if (treeNode.Left != null && treeNode.Left.Value >= treeNode.Value)
            {
                throw new Exception("400");
            }

            if (treeNode.Right != null && treeNode.Right.Value <= treeNode.Value)
            {
                throw new Exception("400");
            }
            if (treeNode.Left != null)
            {
                isBSTNode(treeNode.Left);

                if (treeNode.Right != null)
                {
                    isBSTNode(treeNode.Right);
                }
            }

        }

        public Dictionary<int, LinkedList<TreeNode>> GetListsFromTree()
        {
            list = new Dictionary<int, LinkedList<TreeNode>>();

            if (this.Root != null)
            {
                addNodeToList(this.Root, 0);
            }

            return list;
        }

        private void addNodeToList(TreeNode treeNode, int level)
        {
            if (!list.ContainsKey(level))
            {
                list[level] = new LinkedList<TreeNode>();
            }
            list[level].AddLast(treeNode);
            if (treeNode.Left != null)
            {
                addNodeToList(treeNode.Left, level + 1);
            }
            if (treeNode.Right != null)
            {
                addNodeToList(treeNode.Right, level + 1);
            }
        }

        public bool isBalancedTree()
        {

            try
            {
                findHeightOfNode(this.Root);
            }
            catch (Exception ex)
            {
                if (ex.Message == "400")
                {
                    return false;
                }
            }



            return true;
        }
        private int findHeightOfNode(TreeNode treeNode)
        {
            int left = 0, right = 0;
            if (treeNode.Left == null && treeNode.Right == null)
            {
                treeNode.height = 0;
                return 0;
            }
            if (treeNode.Left != null)
            {
                left = findHeightOfNode(treeNode.Left) + 1;
            }
            if (treeNode.Right != null)
            {
                right = findHeightOfNode(treeNode.Right) + 1;
            }
            if (left > right && left > right + 1)
            {
                throw new Exception("400");
            }
            if (right > left && right > left + 1)
            {
                throw new Exception("400");
            }
            int max = Math.Max(left, right);
            treeNode.height = max;
            return max;
        }
    }



    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int height { get; set; }
        public TreeNode()
        {

        }
        public TreeNode(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
            this.height = 0;
        }
    }
}
