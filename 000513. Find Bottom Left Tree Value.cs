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
    List<int> values = new List<int>();
    public int FindBottomLeftValue(TreeNode root) {
        helper(root, 0);
        return values[values.Count-1];
    }

    public void helper(TreeNode root, int lev){
        if(root==null) return;

        if(lev>=values.Count){
            values.Add(root.val);
            // Console.WriteLine(root.val+" "+values.Count+ " "+lev);
        }

        helper(root.left, lev+1);
        helper(root.right, lev+1);
    }
}
