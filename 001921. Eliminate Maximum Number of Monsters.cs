public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        Dictionary<int, int> time = new Dictionary<int, int>();
        int n=dist.Length;
        int t = 0;
        int maxT = 0;
      // I took a different approach to this problem
      // I am looking at different intervals
      //anything reaching at 0, 0 to 1, 1, 1 to 2, and so on
      // I am considering 0 as 0, 0 to 1 - 1, 1 - 2, 1 to 2 - 3, and soo on
      
        for(int i=0;i<n;i++){
            t = (dist[i]/speed[i])*2 + (dist[i]%speed[i]==0 ? 0 : 1);
            maxT = Math.Max(t, maxT);
            if(time.ContainsKey(t)){
                time[t]++;
            }
            else{
                time.Add(t, 1);
            }
        }
        
        int monsterKill = 0;
        int canKill = 1;
      // there not going to be any monster at 0;
        for(int i=1;i<=maxT;i=i+2){
            if(time.ContainsKey(i)){
                monsterKill += time[i];
            }

            if(time.ContainsKey(i+1)){
                monsterKill += time[i+1];
            }
            // Console.WriteLine(canKill + " " + monsterKill);
            if(canKill < monsterKill){
                return canKill;
            }

            canKill++;
        }
        return Math.Min(canKill, n);
    }
}
