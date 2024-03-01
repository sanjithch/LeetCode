public class Solution {
    public int CountHomogenous(string s) {
      
        int mod = 1000000007;
        int n = s.Length;

        int count = 0;
        int lin = 1;

      // linear scan through array
        for(int i=1;i<n;i++){
            if(s[i]==s[i-1]){
                lin++;
            }
            else{
                count += (int)(((long)(lin*(long)(lin+1))/2)%mod);
                lin = 1;
            }
        }

        count += (int)(((long)(lin*(long)(lin+1))/2)%mod);

        return count;
    }
}
