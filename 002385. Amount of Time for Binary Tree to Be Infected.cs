public class Solution {
    int max = 0;
    
    public int AmountOfTime(TreeNode root, int start) { 
        helper(root, start, -1);
        return max;
    }

    public int helper(TreeNode root, int start, int count){
        max = Math.Max(max, count);

        if(root==null){
            return count;
        }
        int leftCount = 0;
        int rightCount = 0;
        if(root.val==start){
            count = 0;
            helper(root.left, start, 0);
            helper(root.right, start, 0);
        }
        else{
            if(count!=-1){
                count++;
            }
            leftCount = helper(root.left, start, count);
            rightCount = helper(root.right, start, count);
        }

        if(leftCount==-1 && rightCount!=-1){
            leftCount = helper(root.left, start, rightCount+1);
            count = rightCount+1;
        }
        else if(leftCount!=-1 && rightCount==-1){
            count = leftCount+1;
            rightCount = helper(root.right, start, leftCount+1);
        }

        return count;
    }
}
