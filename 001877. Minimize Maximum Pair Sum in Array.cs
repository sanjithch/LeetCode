public class Solution {
    public int MinPairSum(int[] nums) {
        int n = nums.Length;
      // sort the array
      // then find the pairs
        Array.Sort(nums);
        int max = 0;
        for(int i=0;i<n/2;i++){
            max = Math.Max(max, (nums[i]+nums[n-i-1]));
        }
        return max;
    }
}
