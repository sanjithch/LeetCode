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
    bool same = true;
    public bool IsSameTree(TreeNode p, TreeNode q) {
        helper(p, q);
        return same;
    }

    public void helper(TreeNode p, TreeNode q){
        if(p==null && q==null) return;
        if(p==null || q==null) {
            same = false;
            return;
        }


        if(p.val==q.val){
            helper(p.left, q.left);
            helper(p.right, q.right);
        }
        else{
            same = false;
            return;
        }
    }
}
