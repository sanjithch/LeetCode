public class Solution {
    public int CountNicePairs(int[] nums) {
      // given a + rev(b) = b + rev(a);
      // I can change it t a-rev(a) = b-rev(b)
      // to reduce space 
        long mod = 1000000007;
        int n = nums.Length;
        long count = 1;
        long result = 0;
      // stores the a-rev(a) and equates it
        int[] revnums = new int[n];
        for(int i=0;i<n;i++){
            revnums[i] = nums[i]-helper(nums[i]);
        }
        Array.Sort(revnums);
        int pre = revnums[0];
        for(int i=1;i<n;i++){
            if(pre==revnums[i]){
                count++;
            }
            else{
                result = (result + (count*(count-1))/2)%mod;
                count = 1;
            }
            pre = revnums[i]; 
        }
        result = (result + (count*(count-1))/2)%mod;

        return (int)result;
    }

  // reverses the string
    public int helper(int n){
        int res = 0;
        while(n>0){
            res = res*10 + n%10;
            n = n/10;
        }
        return res;
    }
}
