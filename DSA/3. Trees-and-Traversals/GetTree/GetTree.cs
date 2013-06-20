using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTree
{
    class GetTree
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            TreeInput[] input = GetInput(N - 1);
            TreeNode<int> myTree = GetTree(input);

            #region Subtask A:
            Console.WriteLine("Subtask A: The root node is: {0}", myTree.Key);
            #endregion

            #region Subtask B:
            List<TreeNode<int>> leafElements = myTree.GetLeafNodes();
            StringBuilder leafNodesOutput = new StringBuilder();
            leafNodesOutput.Append("Subtask B: Leaf elements of our tree are:");
            foreach (var leafNode in leafElements)
            {
                leafNodesOutput.Append(string.Format(" {0}", leafNode.Key));
            }
            Console.WriteLine(leafNodesOutput);
            #endregion

            #region Subtask C:
            List<TreeNode<int>> middleElements = myTree.GetMiddleNodes();
            StringBuilder middleNodesOutput = new StringBuilder();
            middleNodesOutput.Append("Subtask C: Middle elements of our tree are:");
            foreach (var leafNode in middleElements)
            {
                middleNodesOutput.Append(string.Format(" {0}", leafNode.Key));
            }
            Console.WriteLine(middleNodesOutput);
            #endregion

            #region Subtask D:
            TreeNodePath<int> longestPath = myTree.GetLongestPath();
            StringBuilder longestPathOutput = new StringBuilder();
            longestPathOutput.AppendFormat("Subtask D: The longest path in our tree is: {0}", longestPath.ToString());
            Console.WriteLine(longestPathOutput);
            #endregion

            #region Subtask E:
            List<TreeNodePath<int>> allPossiblePaths = myTree.GetAllPossiblePaths();

            Console.WriteLine("Subtask E: Here are all possible paths with the sum of their nodes:");

            foreach (var possiblePath in allPossiblePaths)
            {
                Console.WriteLine("         The current path is: {0} and the sum of its nodes is: {1}", possiblePath.ToString(), possiblePath.GetPathSum<int>());
            }
            #endregion
            
            #region Subtask F:
            Console.Write("Subtask F: S = ");
            int S = int.Parse(Console.ReadLine());
            foreach (var possiblePath in allPossiblePaths)
            {
                int currPossiblePathSum = possiblePath.GetPathSum<int>();
                if (currPossiblePathSum == S)
                {
                    Console.WriteLine("         The current path with sum of the nodes that is: {0} is: {1}", S, possiblePath.ToString());
                }
            }
            #endregion
        }

        private static TreeInput[] GetInput(int inputRowsCount)
        {
            TreeInput[] input = new TreeInput[inputRowsCount];

            for (int inputRowIndex = 0; inputRowIndex < inputRowsCount; inputRowIndex++)
            {
                string currInputRow = Console.ReadLine();
                currInputRow = currInputRow.Trim();
                string[] currInputElements = currInputRow.Split(' ');
                if (currInputElements.Length != 2)
                {
                    throw new ArgumentException("Elements in the input on each single line should be exactly two!");
                }
                else
                {
                    input[inputRowIndex].ParentNodeKey = int.Parse(currInputElements[0]);
                    input[inputRowIndex].ChildNodeKey = int.Parse(currInputElements[1]);
                }
            }

            return input;
        }

        private static TreeNode<int> GetTree(TreeInput[] input)
        {
            List<TreeNode<int>> myTrees = new List<TreeNode<int>>();
            for (int index = 0; index < input.Length; index++)
            {
                AddNode(myTrees, input[index].ParentNodeKey, input[index].ChildNodeKey);

            }
            if (myTrees.Count != 1)
            {
                throw new ArgumentException("Input is wrong! It isn't possible to create single tree!");
            }
            else
            {
                return myTrees[0];
            }
        }

        private static void AddNode(List<TreeNode<int>> myTrees, int parentKey, int childKey)
        {

            if (myTrees.Count == 0)
            {
                myTrees.Add(new TreeNode<int>(parentKey));

                myTrees[0].AddFirstChildNode(new TreeNode<int>(childKey));


            }
            else
            {
                bool foundTreeNode = false;
                foreach (var treeNode in myTrees)
                {
                    TreeNode<int> boofTree = treeNode.FindChildNode(parentKey);
                    if (boofTree != null)
                    {
                        foundTreeNode = true;
                        bool foundChildTreeNode = false;
                        foreach (var childTreeNode in myTrees)
                        {
                            if (childTreeNode.Key.Equals(childKey))
                            {
                                foundChildTreeNode = true;
                                treeNode.AddFirstChildNode(childTreeNode);
                                myTrees.Remove(childTreeNode);
                                break;
                            }
                        }

                        if (!foundChildTreeNode)
                        {
                            boofTree.AddFirstChildNode(new TreeNode<int>(childKey));
                        }

                        break;
                    }
                }

                if (!foundTreeNode)
                {
                    bool foundChildTreeNode = false;

                    for (int index = 0; index < myTrees.Count; index++)
                    {
                        if (myTrees[index].Key.Equals(childKey))
                        {
                            foundChildTreeNode = true;
                            TreeNode<int> boofChildTreeNode = myTrees[index];
                            myTrees[index] = new TreeNode<int>(parentKey);

                            myTrees[index].AddFirstChildNode(boofChildTreeNode);
                            break;
                        }
                    }

                    if (!foundChildTreeNode)
                    {
                        TreeNode<int> boofTreeNode = new TreeNode<int>(parentKey);

                        boofTreeNode.AddFirstChildNode(new TreeNode<int>(childKey));

                        myTrees.Add(boofTreeNode);
                    }
                }
            }
        }
    }
}
