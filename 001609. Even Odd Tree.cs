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
    List<int> arr = new List<int>();
    bool evenOdd = true;
    public bool IsEvenOddTree(TreeNode root) {
        helper(root, 0);

        return evenOdd;
    }

    public void helper(TreeNode root, int level){
        if(!evenOdd) return;
        if(root==null) return;

        if(root.val%2==level%2){
            evenOdd = false;
        }

        if(arr.Count<=level){
            arr.Add(root.val);
        }
        else if(level%2==0){
            if(root.val > arr[level]){
                arr[level] = root.val;
            }else{
                evenOdd = false;
            }
        }else{
            if(root.val < arr[level] ){
                arr[level] = root.val;
            }else{
                evenOdd = false;
            }
        }

        helper(root.left, level+1);
        helper(root.right, level+1);
    }
}
