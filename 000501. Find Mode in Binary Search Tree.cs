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
    int max = 1;
    Dictionary<int, int> arr = new Dictionary<int, int>();
  // storing the values in dictionary, for easy access
    public int[] FindMode(TreeNode root) {
        helper(root);
        int count = 0;
        foreach(var a in arr){
            if(a.Value==max) count++;
        }
        int[] result = new int[count];
        int i= 0;
        foreach(var a in arr){
            if(a.Value==max) result[i++] = a.Key;
        }

        return result;
    }

    public void helper(TreeNode root){
        if(root==null) return;
        if(arr.ContainsKey(root.val)) {
            arr[root.val]++;
            // Console.WriteLine(arr[root.val]);
            max = Math.Max(arr[root.val], max);
        }
        else arr.Add(root.val, 1);
        helper(root.left);
        helper(root.right);
    }

}
