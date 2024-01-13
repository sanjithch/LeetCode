public class Solution {
    public int MinSteps(string s, string t) {
        int n = t.Length;
        int[] arr = new int[26];
        int count = 0;
        for(int i=0;i<n;i++){
            arr[t[i]-'a']++;
            arr[s[i]-'a']--;
        }

        for(int i=0;i<26;i++){
            if(arr[i]>0) count+= arr[i];
        }

        return count;
    }
}
