public class Solution {
    StringBuilder result = new StringBuilder();
    public string Tree2str(TreeNode root) {
        result.Append(""+root.val);
        if(root.left!=null) addStringHelper(root.left);
        if(root.right!=null) {
            if(root.left==null) result.Append("()");
            addStringHelper(root.right);  
        }

        return result.ToString(); 
    }

    public void addStringHelper(TreeNode root){
        result.Append("(");
        result.Append(root.val);
        if(root.left!=null) addStringHelper(root.left);

        if(root.right!=null){
            if(root.left==null) result.Append("()");
            addStringHelper(root.right);
        } 

        result.Append(")");
    }
}
