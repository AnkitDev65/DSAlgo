using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.TreeTraversal
{
    public class Solution3
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
