public class Solution {
    public int CountPalindromicSubsequence(string s) {
        // with greedy approach we can do it with O(n3), and space complexity of O(n) 
      // for tracking each element, to avoid repetition
        bool[] isVisited = new bool[26];
        int n = s.Length;
      // for calculating different indexes than matching
        int differentChar = 0;
      // to calculate max chars
        int maxChars = 0;
        int result = 0;
        bool isSameChar = false;
        bool gotwithSameChar = false;
        for(int i=0;i<n;i++){
          //For each element we check this, for avoiding repetitions
            bool[] countingChars = new bool[26];
            isSameChar = false;
            gotwithSameChar = false;
            if(isVisited[s[i]-'a']) continue;
            maxChars = 0;
            differentChar = 0;
            isSameChar = false;
            for(int j=i+1;j<n;j++){
                if(s[i]==s[j]){
                    if(isSameChar && !gotwithSameChar) {
                        differentChar++;
                        gotwithSameChar = true;
                    }
                    maxChars = Math.Max(maxChars, differentChar);
                    isSameChar = true;
                    continue;
                }
                if(!countingChars[s[j]-'a']){
                    differentChar++;
                    countingChars[s[j]-'a'] = true;
                }
            }
            result += maxChars;
            isVisited[s[i]-'a'] = true;
        }

        return result;
    }
}
