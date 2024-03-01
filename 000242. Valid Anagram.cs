public class Solution {
    public bool IsAnagram(string s, string t) {
      // return false if they don't have equal length
        if(s.Length!=t.Length) return false;
        // to store the each lower case characters
        int[] ch = new int[26];
        for(int i=0;i<s.Length;i++) {
            ch[s[i]-'a']++;
            ch[t[i]-'a']--;
        }

        for(int i=0;i<26;i++){
            if(ch[i]!=0) return false;
        }

        return true;
    }
}
