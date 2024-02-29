public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string s in words){
            if(IsPalind(s)) return s;
        }

        return "";
    }

    public bool IsPalind(string s){
        int n = s.Length;
        for(int i=0;i<=n/2;i++){
            if(s[i]!=s[n-i-1]){
                return false;
            }
        }

        return true;
    }
}
