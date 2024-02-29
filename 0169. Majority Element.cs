public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        for(int i=0;i<=n/2;i++){
            if(nums[i]==nums[i+n/2]){
                return nums[i];
            }
        }

        return nums[0];
    }
}
