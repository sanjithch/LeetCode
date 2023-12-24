public class Solution {
    public int MinOperations(string s) {
        int start = s[0]-'0';
        int n = s.Length;
        int count = 0;
        for(int i=1;i<n;i++){
            if(start==s[i]-'0'){
                count++;
            }
            start = start ^ 1;
        }
        if(count > n/2) count = n - count;

        return count;
    }
}
