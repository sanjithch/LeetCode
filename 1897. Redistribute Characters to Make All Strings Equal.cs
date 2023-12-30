public class Solution {
    public bool MakeEqual(string[] words) {
        int n = words.Length;

        int[] arr = new int[26];
        for(int i=0;i<n;i++) {
            foreach(char c in words[i]){
                arr[c-'a']++;
            }
        }
        
        for(int i=0;i<26;i++){
            if(arr[i]%n!=0) return false;
        }

        return true;
    }
}
