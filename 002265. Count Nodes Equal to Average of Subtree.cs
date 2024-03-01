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
    int result = 0;
    public int AverageOfSubtree(TreeNode root) {
        helper(root);
        return result;
    }

  // Imagine any node in string
  // it should check its subtree average is equal to 0 or not
  // return its sum to the parent
  // count the such cases, done with result
    public (int sum, int count) helper(TreeNode root){
        if(root==null) return (0,0);
        int s = 0;
        int c = 0;
      // left child
        (s, c) = helper(root.left);
        int sum = s;
        int count = c;
      // right child
        (s, c) = helper(root.right);
        sum += s+root.val;
        count += c+1;

        if(root.val == (sum/count)) result++;
      // return its sum and count to the parent
        return (sum, count);
    }
}
