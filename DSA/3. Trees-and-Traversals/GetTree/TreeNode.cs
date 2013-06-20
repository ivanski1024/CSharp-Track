using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTree
{
    public class TreeNode<K>
    {
        public static string IdentationForVisualization = "-";

        private List<TreeNode<K>> childNodes;

        public TreeNode(K key)
        {
            this.Key = key;
            this.ChildNodes = new List<TreeNode<K>>();
        }

        public K Key;

        public List<TreeNode<K>> ChildNodes
        {
            get
            {
                return this.childNodes;
            }

            private set
            {
                this.childNodes = value;
            }
        }

        /// <summary>
        /// Adds a new child node on this node. If a node with the same key exists the method throws an exception
        /// </summary>
        /// <param name="node">The node</param>
        public void AddFirstChildNode(TreeNode<K> node)
        {
            foreach (var childNode in this.ChildNodes)
            {
                if (childNode.Key.Equals(node.Key))
                {
                    throw new ArgumentException("A child node with the same key already exists!");
                }
            }
            this.ChildNodes.Add(node);
        }

        /// <summary>
        /// Removes a child node with the same key as the one given.
        /// </summary>
        /// <param name="nodeKey">the node key we want to remove</param>
        /// <returns>true if the method removed a node and false if the method didn't.</returns>
        public bool RemoveFirstChildNode(K nodeKey)
        {
            int countOfRemovedNodes = this.ChildNodes.RemoveAll(node => node.Key.Equals(nodeKey));
            if (countOfRemovedNodes > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TreeNode<K> FindChildNode(K nodeKey)
        {
            if (this.Key.Equals(nodeKey))
            {
                return this;
            }
            else
            {
                foreach (var childNode in this.childNodes)
                {
                    if (childNode.Key.Equals(nodeKey))
                    {
                        return childNode;
                    }
                    else
                    {
                        TreeNode<K> boofNode = childNode.FindChildNode(nodeKey);
                        if (boofNode != null)
                        {
                            return boofNode;
                        }
                    }
                }
                return null;
            }
        }

        public List<TreeNode<K>> GetLeafNodes()
        {
            List<TreeNode<K>> leafNodes = new List<TreeNode<K>>();

            GetLeafNodes(leafNodes);

            return leafNodes;
        }

        /// <summary>
        /// Gets a list of all middle nodes in the tree starting from this node.
        /// </summary>
        /// <returns>The list with references of the nodes.</returns>
        public List<TreeNode<K>> GetMiddleNodes()
        {
            List<TreeNode<K>> middleNodes = new List<TreeNode<K>>();

            GetMiddleNodes(middleNodes, true);

            return middleNodes;
        }

        /// <summary>
        /// Gets the longest path starting from this node.
        /// </summary>
        /// <returns>A reference to an element of the TreeNodePath<in T> class which contains references to the exact nodes.</returns>
        public TreeNodePath<K> GetLongestPath()
        {
            List<TreeNodePath<K>> allPossiblePaths = new List<TreeNodePath<K>>();
            TreeNodePath<K> currentPath = new TreeNodePath<K>();

            GetAllPossiblePaths(allPossiblePaths, currentPath);

            TreeNodePath<K> longestPath;

            if (allPossiblePaths.Count == 0)
            {
                return null;
            }
            else
            {
                longestPath = allPossiblePaths[0];
                for (int pathIndex = 1; pathIndex < allPossiblePaths.Count; pathIndex++)
                {
                    if (allPossiblePaths[pathIndex].Length > longestPath.Length)
                    {
                        longestPath = allPossiblePaths[pathIndex];
                    }
                }
            }
            return longestPath;
        }

        public List<TreeNodePath<K>> GetAllPossiblePaths()
        {
            List<TreeNodePath<K>> allPossiblePaths = new List<TreeNodePath<K>>();
            TreeNodePath<K> currentPath = new TreeNodePath<K>();
            this.GetAllPossiblePaths(allPossiblePaths, currentPath);
            return allPossiblePaths;
        }

        public string ToString(string indentation, string indetationElement)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0}{1}", indentation, this.Key.ToString()));
            foreach (var childNode in this.ChildNodes)
            {
                output.Append(childNode.ToString(string.Format("{0}{1}", indentation, indetationElement), indetationElement));
            }
            return output.ToString();
        }

        public override string ToString()
        {
            return this.ToString(string.Empty, IdentationForVisualization);
        }

        private void GetLeafNodes(List<TreeNode<K>> leafNodes)
        {
            if (this.ChildNodes.Count == 0)
            {
                leafNodes.Add(this);
            }
            else
            {
                foreach (var childNode in this.ChildNodes)
                {
                    childNode.GetLeafNodes(leafNodes);
                }
            }
        }

        private void GetMiddleNodes(List<TreeNode<K>> middleNodes, bool firstNode)
        {
            if (this.ChildNodes.Count > 0)
            {
                if (!firstNode)
                {
                    middleNodes.Add(this);
                }
                foreach (var childNode in this.ChildNodes)
                {
                    childNode.GetMiddleNodes(middleNodes, false);
                }
            }
        }

        private void GetAllPossiblePaths(List<TreeNodePath<K>> allPossiblePaths, TreeNodePath<K> currentPath)
        {
            currentPath.AddLastNode(this);

            if (this.ChildNodes.Count == 0)
            {
                allPossiblePaths.Add(currentPath.GetPathCopy());
            }
            else
            {
                foreach (var childNode in this.ChildNodes)
                {
                    childNode.GetAllPossiblePaths(allPossiblePaths, currentPath);
                }
            }

            currentPath.RemoveLastNode();
        }
    }
}