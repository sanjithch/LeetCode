public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int sum = nums.Sum();
        int cum = 0;
      // helps to get the differences
        for(int i=0;i<n;i++){
            cum += nums[i];
            result[i] = nums[i]*(i+1)-cum+sum-cum-(n-1-i)*nums[i];
        }
        return result;
    }
}
