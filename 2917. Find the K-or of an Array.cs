public class Solution {
    public int FindKOr(int[] nums, int k) {
        int n = nums.Length;
        int res = nums[0];
        if(k>=n){
            for(int i=1;i<n;i++) res &= nums[i];
            return res;
        }
        if(k==1){
           for(int i=1;i<n;i++) res |= nums[i];
            return res;
        }
        
        int max = nums[0];
      // getting the maximum in an array
        for(int i=0;i<n;i++) max = Math.Max(max, nums[i]);
        
        long bitC = 1;
        int count = 0;
        res = 0;
      
        while(bitC <= max){
            count = 0;
            for(int i=0;i<n;i++){
                if((nums[i] & bitC) == bitC){
                    count++;
                }
            }
            if(count >= k){
                res += (int)bitC;
            }
            bitC = bitC << 1;
        }
        
        return res;
    }
}
