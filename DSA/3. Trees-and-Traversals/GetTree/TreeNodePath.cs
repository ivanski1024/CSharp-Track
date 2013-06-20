using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTree
{
    public class TreeNodePath<K>
    {
        private LinkedList<TreeNode<K>> nodes;

        public TreeNodePath()
        {
            this.nodes = new LinkedList<TreeNode<K>>();
        }

        public LinkedList<TreeNode<K>> Nodes
        {
            get
            {
                return this.nodes;
            }

            private set
            {
                this.nodes = value;
            }
        }

        public int Length
        {
            get
            {
                return this.nodes.Count;
            }
        }

        public void AddLastNode(TreeNode<K> node)
        {
            this.Nodes.AddLast(node);
        }

        public void RemoveLastNode()
        {
            this.Nodes.RemoveLast();
        }

        public dynamic GetPathSum<K>()
        {
            dynamic sum = 0;
            foreach (dynamic element in this.Nodes)
            {
                sum += element.Key;
            }
            return sum;
        }

        public TreeNodePath<K> GetPathCopy()
        {
            TreeNodePath<K> newPath = new TreeNodePath<K>();

            for (int nodeIndex = 0; nodeIndex < this.Nodes.Count; nodeIndex++)
            {
                newPath.AddLastNode(this.Nodes.ElementAt(nodeIndex));
            }

            return newPath;
        }

        public override string ToString()
        {
            if (this.Nodes.Count == 0)
            {
                return "/empty path/";
            }
            else
            {
                StringBuilder pathVizualization = new StringBuilder();

                pathVizualization.Append(this.Nodes.ElementAt(0).Key);

                for (int nodeIndex = 1; nodeIndex < this.Nodes.Count; nodeIndex++)
                {
                    pathVizualization.AppendFormat(" --> {0}", this.Nodes.ElementAt(nodeIndex).Key);
                }

                return pathVizualization.ToString();
            }
        }
    }
}