using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Graphs
{
    public class Graph
    {
        public GraphNode[] GraphNodes { get; set; }
        public Queue<GraphNode> BFSQueue { get; set; }

        public Graph()
        {
            this.BFSQueue = new Queue<GraphNode>();
            this.GraphNodes = new GraphNode[4];
            for (int i = 0; i < this.GraphNodes.Length; i++)
            {
                this.GraphNodes[i] = new GraphNode
                {
                    Neighbours = new List<GraphNode>(),
                    value = i+1
                };
            }
            this.GraphNodes[0].BFSMarked = true;
            this.GraphNodes[0].Neighbours.Add(this.GraphNodes[1]);
            this.GraphNodes[0].Neighbours.Add(this.GraphNodes[2]);
            this.GraphNodes[1].Neighbours.Add(this.GraphNodes[2]);
            this.GraphNodes[1].Neighbours.Add(this.GraphNodes[3]);
            this.GraphNodes[2].Neighbours.Add(this.GraphNodes[1]);
            this.GraphNodes[2].Neighbours.Add(this.GraphNodes[3]);
            this.GraphNodes[3].Neighbours.Add(this.GraphNodes[0]);
            this.GraphNodes[3].Neighbours.Add(this.GraphNodes[1]);
            this.BFSQueue.Enqueue(this.GraphNodes[0]);
        }
        public GraphNode FindByDFS(int desired)
        {
            GraphNode n = this.GraphNodes[0];
            return DFS(n,desired);
        }
        public GraphNode BFS(int desired)
        {
            if (this.BFSQueue.Count <=0)
            {
                return null;
            }
            GraphNode d = this.BFSQueue.Dequeue();
            if (d.value == desired)
            {
                return d;
            }
            foreach (var item in d.Neighbours)
            {
                item.BFSMarked = true;
                this.BFSQueue.Enqueue(item);
            }
            return BFS(desired);
        }
        private GraphNode DFS(GraphNode n, int desired)
        {
            n.visited = true;
            if (n.value == desired)
            {
                return n;
            }
            foreach (var item in n.Neighbours)
            {
                return DFS(item, desired);
            }
            return null;
        }
    }

    public class GraphNode
    {
        public int value { get; set; }
        public List<GraphNode> Neighbours { get; set; }
        public bool visited { get; set; }
        public bool BFSMarked { get; set; }
        public GraphNode()
        {
            this.visited = false;
            this.BFSMarked = false;
        }
    }

}
