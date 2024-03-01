public class Solution {
    public int ReductionOperations(int[] nums) {
        int n = nums.Length;
      //Sort the array
        Array.Sort(nums);
        int count = 0;
        int result = 0;
      //Count will check the count of numbers, result will add the elements that changes the need
        for(int i=n-2;i>=0;i--){
            if(nums[i+1]==nums[i]){
                count++;
            }
            else{
                count++;
                result += count;
            }
        }

        return result;
    }
}
