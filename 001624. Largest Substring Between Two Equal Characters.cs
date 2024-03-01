public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int n = s.Length;
        int[] hash = new int[26];
        Array.Fill(hash, -1);

        int len = 0;
        int result = -1;
        
        for(int i=0;i<n;i++){
            if(hash[s[i]-'a']==-1){
                hash[s[i]-'a'] = i;
            }
            else{
                result = Math.Max(result, i-hash[s[i]-'a']-1);
            }
        }

        return result;
    }
}
