public class Solution {
    List<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
       if(root!=null) helper(root);

       return result;
    }

    public void helper(TreeNode root){
        if(root.left!=null) helper(root.left);
        result.Add(root.val);
        if(root.right!=null) helper(root.right);
    }
}
