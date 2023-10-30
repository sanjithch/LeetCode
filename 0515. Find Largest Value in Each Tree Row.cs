public class Solution {
    int len = 0;
    List<int> result = new List<int>();
    public IList<int> LargestValues(TreeNode root) {
        helper(root, 0);
        return result;
    }

    // I will tell you which level our node is in
    public void helper(TreeNode root, int i){
        if(root==null) return;
        // If the row doesn't exist add it in
        // else check which is Max
        if(result.Count < i+1) result.Add(root.val);
        else result[i] = Math.Max(result[i], root.val);
        getMyLength(root.left, i+1);
        getMyLength(root.right, i+1);
    }
}
