public class Solution {
    public int NumSquares(int n) {
        int[] dp = new int[n+1];

        for(int i=1;i<=n;i++){
            int sr = (int)Math.Sqrt(i);
            if(sr*sr == i){
                dp[i]=1;
            }else{
                int min = 1000000;
                for(int j=i-1;j>i/2;j--){
                    min = Math.Min(dp[j]+dp[i-j], min);
                }
                dp[i]=min;
            }

        }

        return dp[n];
    }
}
