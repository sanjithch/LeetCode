public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;

        int sum = 0;
        foreach(int val in nums){
            sum += val;
        }

        return (n*(n+1))/2 - sum;
    }
}
