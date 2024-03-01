public class Solution {
    Dictionary<int, Dictionary<int, int>> dp = new Dictionary<int, Dictionary<int, int>>();
    int mod = 1000000007;
    public int NumRollsToTarget(int n, int k, int target) {
        int min = n;
        int max = n*k;
        if(target < min || target > max) return 0;
        return helper(n, k, target);   
    }

    public int helper(int n, int k, int tar){
        if(n*k < tar || tar < 1) return 0;
        if(n==1) return 1;
        int sum = 0;
        if(dp.ContainsKey(tar)){
            if(dp[tar].ContainsKey(n)) return dp[tar][n];
            else{
                for(int i=1;i<=k;i++){
                    sum = (sum + helper(n-1, k, tar - i))%mod;
                }
                dp[tar].Add(n, sum);
                return sum;
            }
        }
        else{
            for(int i=1;i<=k;i++){
                sum = (sum + helper(n-1, k, tar - i))%mod;
            }
            dp.Add(tar, new Dictionary<int, int>(){{n, sum}});
            return sum;
        }
        return sum;
    }
} 
