public class Solution {
    Dictionary<(int, int, int), int> map = new Dictionary<(int, int, int), int>();

    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n = jobDifficulty.Length;
        if(n<d) return -1;
        return helper(jobDifficulty, d, 0, n, jobDifficulty[0]);
    }

    public int helper(int[] job, int d, int curr, int n, int max){

        if(map.ContainsKey((d, curr, max))) return map[(d, curr, max)];
        
        if(curr==n-1) {
            if(d==1){
                return Math.Max(max, job[curr]);
            }
            return 300001;
        }
        if(d==0) return 300001;
        if(d==1){
            int lmax = 0;
            for(int i=curr;i<n;i++){
                lmax = Math.Max(lmax, job[i]);
            }
            return lmax;
        }

        int withoutRemoval = 300001;
        int withRemoval = 300001;

        if(curr<n-1) withoutRemoval = helper(job, d, curr+1, n, Math.Max(max, job[curr]));
        if(curr<n-1 && d>0) withRemoval =  Math.Max(max, job[curr]) + helper(job, d-1, curr+1, n, job[curr+1]);


        map.Add((d, curr, max), Math.Min(withRemoval, withoutRemoval));
        return map[(d, curr, max)];

    }

}
