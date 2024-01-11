public class Solution {
    int result = 0;
    public int MaxAncestorDiff(TreeNode root) {
        helper(root, root.val, root.val);
        return result;
    }

    public void helper(TreeNode root, int min, int max){
        if(root==null) return;
        min = Math.Min(min, root.val);
        max = Math.Max(max, root.val);
        result = Math.Max(result, max-min);
        helper(root.left, min, max);
        helper(root.right, min, max);
    }
}
