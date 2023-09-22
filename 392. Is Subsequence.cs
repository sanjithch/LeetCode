// Solutions with time complexity O(n) it depends on length of s
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int n = s.Length;
        int m = t.Length;

        if(n>m) return false;

        int i=0;
        int j=0;

      //Until any one of the pointers exceeds its limit
        while(i<n && j<m){
            if(s[i]==t[j]){
                i++;
            }
            j++;
        }
        if(i==n) return true;
        return false;
    }
}
