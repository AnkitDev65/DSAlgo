using DsAlgo.TreeTraversal;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
//Two approaches.
public class Solution_PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;
        if (targetSum == root.val && root.left == null && root.right == null) return true;
        targetSum = targetSum - root.val;
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
    }
}

public class Solution1 {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) return false;
        return sln(root, targetSum, 0);
    }

    public bool sln(TreeNode node, int targetSum, long currSum){
        if(node == null) 
            return false;
        
        currSum = currSum + node.val;
        if(node.left == null && node.right == null) {
            return currSum == targetSum;
        }
         
        return sln(node.left, targetSum, currSum) || sln(node.right, targetSum, currSum);
    }
}
