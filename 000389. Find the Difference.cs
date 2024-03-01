public class Solution {
    public char FindTheDifference(string s, string t) {
        int n = s.Length;
        int[] count = new int[26];

       //mapping the count of chars in each string. the extra one will leave a -1 in array
        for(int i=0;i<n;i++){
            count[s[i]-'a']++;
            count[t[i]-'a']--;
        }
        count[t[n]-'a']--;

        for(int i=0;i<26;i++){
            if(count[i]!=0) return Convert.ToChar(i+97);
        }

        return 'a';
    }
}
