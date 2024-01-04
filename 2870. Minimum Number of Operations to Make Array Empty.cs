public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);

        int ways = 0;
        int pre = 0;
        int curr = 0;
        int value = 0;

        while(++curr < n){
            if(nums[curr-1]!=nums[curr]){
                value = helper(curr-pre);
                if(value==-1) return -1;
                ways += value;
                pre = curr;
            }
        }
        value = helper(curr-pre);
        if(value==-1) return -1;
        ways += value;
        pre = curr;

        return ways;

    }

    public int helper(int val){
        if(val==1) return -1;
        int total = 0;
        int div = val/3;
        int rem = val%3;
        if(rem==0){
            return div;
        }
        return div+1;
    }
}
