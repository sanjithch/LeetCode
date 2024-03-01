public class Solution {
    public int MinimumSum(int[] nums) {
        int n = nums.Length;
        int sum = 2500;
      // a greedy approach will do the Job
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                for(int k=j+1;k<n;k++){
                    if(nums[i]<nums[j] && nums[j]>nums[k]){
                        sum = Math.Min(sum, nums[i]+nums[j]+nums[k]);
                    }
                }
            }
        }
        
        if(sum==2500) return -1;
        return sum;
    }
}
