public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int n = words.Length;
        int[] arr = new int[26];
        for(int i=0;i<chars.Length;i++){
            arr[chars[i]-'a']++;
        }
        int result = 0;
        for(int i=0;i<n;i++){
            if(doesItcontain(arr, words[i])){
                result += words[i].Length;
            }
        }

        return result;
    }

    public bool doesItcontain(int[] arr, string s){
        int[] sarr = new int[26];
        for(int i=0;i<s.Length;i++){
            sarr[s[i]-'a']++;
        }
        for(int i=0;i<26;i++){
            if(arr[i]<sarr[i]) return false;
        }
        return true;
    }
}
