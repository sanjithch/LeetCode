public class Solution {
    public long MinimumSteps(string s) {
      int n = s.Length;
      // count for each 1 balls
        int numOnes = 0;
      // track for total swaps
        long numSwaps = 0;
        for(int i=0;i<n;i++){
            if(s[i]=='0'){
                numSwaps += numOnes;
            }
            else{
                numOnes++;
            }
        }
        
        return numSwaps;
    }
}
