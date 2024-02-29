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
public class Solution {
    int maxLen = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        helper(root);
        return maxLen;
    }

    public int helper(TreeNode root){
        if(root==null){
            return 0;
        }

        int left = helper(root.left);
        int right = helper(root.right);

        maxLen = Math.Max(maxLen, left+right);
        return Math.Max(left, right)+1;
    }
}
