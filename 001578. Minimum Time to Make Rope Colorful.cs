public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int n = neededTime.Length;
        int time = 0;
        for(int i=0;i<n-1;i++){
            if(colors[i]==colors[i+1]){
                time += Math.Min(neededTime[i], neededTime[i+1]);
                neededTime[i+1] = Math.Max(neededTime[i], neededTime[i+1]);
            }
        }
        return time;
    }
}
