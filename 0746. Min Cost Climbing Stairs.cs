public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
      int n = cost.Length;
      int[] dp = new int[n+1];
      dp[0] = 0;
      dp[1] = cost[0];
      dp[2] = cost[1];
      int ind = 2;
      while(ind < n+1){
          dp[ind] = cost[ind-1]+Math.Min(dp[ind-1], dp[ind-2]);
          ind++;
      }

      return Math.Min(dp[n],dp[n-1]);
    }
}
