public class Solution {
    public int IntegerBreak(int n) {
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 1;
        // dp[3] = 3;
        int left = 1;
        int right = 1;

        // iterating through possible outcomes
        
        for(int i=3;i<=n;i++){
            for(int j=1;j<=i/2+1;j++){
              // taking one guaranteed element and checking it with possible outcomes
                left = j;
                right = i-j;
                //We can get in the following ways possible
                //When we are not sure how to approach problems, try starting with possibilities
                dp[i] = getMax(left*right, dp[left]*right, dp[i], dp[left]*dp[right], left*dp[right]);
            }
        }

        return dp[n];
    }

   // to get the maximum of five elements
    public int getMax(int x, int y, int z, int a, int b){
        int max = 0;
        max = Math.Max(max, x);
        max = Math.Max(max, y);
        max = Math.Max(max, z);
        max = Math.Max(max, a);
        max = Math.Max(max, b);

        return max;
    }
}
