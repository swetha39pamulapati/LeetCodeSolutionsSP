using System;
using System.Collections.Generic;

namespace _126.AllNodesSistanceKFromNodes
{
    //https://www.youtube.com/watch?v=nPtARJ2cYrg
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {

            List<int> res = new List<int>();
            if (root == null)
                return res;

            Dictionary<TreeNode, List<TreeNode>> dic = new Dictionary<TreeNode, List<TreeNode>>();
            buildGraph(root, dic);

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(target);
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            visited.Add(target);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    if (k == 0)
                    {
                        for (int j = 0; j < size; j++)
                            res.Add(queue.Dequeue().val);
                        return res;
                    }
                    else
                    {
                        var curr = queue.Dequeue();

                        foreach (var next in dic[curr])
                        {
                            if (!visited.Contains(next))
                            {
                                queue.Enqueue(next);
                                visited.Add(next);
                            }
                        }
                    }
                }

                k--;
            }

            return res;
        }

        private void buildGraph(TreeNode node, Dictionary<TreeNode, List<TreeNode>> dic)
        {
            if (node == null)
                return;

            if (!dic.ContainsKey(node))
                dic.Add(node, new List<TreeNode>());

            if (node.left != null)
            {
                dic[node].Add(node.left);

                if (!dic.ContainsKey(node.left))
                    dic.Add(node.left, new List<TreeNode>());
                dic[node.left].Add(node);

                buildGraph(node.left, dic);
            }

            if (node.right != null)
            {
                dic[node].Add(node.right);

                if (!dic.ContainsKey(node.right))
                    dic.Add(node.right, new List<TreeNode>());
                dic[node.right].Add(node);

                buildGraph(node.right, dic);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = null;
            root = new TreeNode(3);
            root.left = new TreeNode(5);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(6);
            root.left.right = new TreeNode(2);
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(8);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(4);
            IList<int> result = p.DistanceK(root, new TreeNode(5), 2);
            Console.WriteLine(result.Count);
        }
    }
}
