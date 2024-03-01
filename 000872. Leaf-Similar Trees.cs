public class Solution {
    List<int> arr = new List<int>();
    bool result = true;
    int ind = 0;
    int len = 0;
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        helper(root1);
        ind = 0;
        result = true;
        helper(root2);
        if(ind!=len){
            return false;
        }

        return result;
    }
    
    public void helper(TreeNode root){
        if(root==null) return;
        if(root.left==null && root.right==null){
            if(ind+1>len){
                arr.Add(root.val);
                ind++;
                len++;
                result = false;
            }
            else{
                if(arr[ind]!=root.val){
                    result = false;
                    return;
                }
                ind++;
            }
            
        }

        helper(root.left);
        helper(root.right);
    }

}
