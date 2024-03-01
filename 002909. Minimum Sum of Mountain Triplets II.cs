public class Solution {
    public int MinimumSum(int[] nums) {
        int n = nums.Length;
        // to store the minimums from and right
        int[] leftMin = new int[n];
        int[] rightMin = new int[n];
        int sum = -1;
        
        leftMin[0] = nums[0];
        rightMin[n-1] = nums[n-1];
        
        for(int i=1;i<n;i++){
            leftMin[i] = Math.Min(leftMin[i-1], nums[i]);
            rightMin[n-i-1] = Math.Min(rightMin[n-i], nums[n-i-1]);
        }
        
        // getting max mid
        for(int i=1;i<n-1;i++){
            if(leftMin[i-1]<nums[i] && nums[i]>rightMin[i+1]){
                if(sum==-1){
                    sum = leftMin[i-1]+nums[i]+rightMin[i+1];
                }
                sum = Math.Min(sum, leftMin[i-1]+nums[i]+rightMin[i+1]);
            }
        }
        return sum;
    }
}
