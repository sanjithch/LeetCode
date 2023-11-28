public class Solution {
    public int KnightDialer(int n) {
        long mod = 1000000007;
        if(n==1) return 10;
        long[,] dp = new long[n+1,10];
        for(int i=0;i<10;i++) dp[1,i] = 1;
      // getting the next moves from previous
        for(int i=2;i<=n;i++){
            dp[i,0] = (dp[i-1,4]+dp[i-1,6])%mod;
            dp[i,1] = (dp[i-1,6]+dp[i-1,8])%mod;
            dp[i,2] = (dp[i-1,9]+dp[i-1,7])%mod;
            dp[i,3] = (dp[i-1,8]+dp[i-1,4])%mod;
            dp[i,4] = (dp[i-1,0]+dp[i-1,3]+dp[i-1,9])%mod;
            dp[i,6] = (dp[i-1,0]+dp[i-1,1]+dp[i-1,7])%mod;
            dp[i,7] = (dp[i-1,2]+dp[i-1,6])%mod;
            dp[i,8] = (dp[i-1,1]+dp[i-1,3])%mod;
            dp[i,9] = (dp[i-1,4]+dp[i-1,2])%mod;
        }
        long result = 0;
        for(int i=0;i<10;i++){
            result = (result+dp[n,i])%mod;
        }

        return (int)result;
       // 0 - 2 - 2
       // 1 - 2 - 2
       // 2 - 2 - 2
       // 3 - 2 - 2
       // 4 - 3 - 3
       // 5 - 0
       // 6 - 3
       // 7 - 2
       // 8 - 2
       // 9 - 2
    }
}
