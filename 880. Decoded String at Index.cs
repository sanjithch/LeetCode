public class Solution {
    public string DecodeAtIndex(string s, int k) {
        int n = s.Length;
        long wordCount = 0;
        int matchIndex = 0;
        int currIndex = 0;
        int times = 0;

        // getting the words count to estimate in between
        for(int i=0;i<n;i++){
            currIndex = (int)s[i];
            if(currIndex > 96 && currIndex < 123){//97 to 122
               wordCount++;
               if(wordCount==k){
                   matchIndex = i;
                    break;
               }
            }
            else {
                times = currIndex - 48;
                wordCount = wordCount*times;
                if(wordCount>=k){
                    matchIndex = i;
                    break;
                }
            }
        }
        string result = "";

        //remapping from back
        for(int i=matchIndex;i>=0;i--){
            currIndex = (int)s[i];
            if(k==0 || wordCount==k){
                while(i>=0){
                    currIndex = (int)s[i];
                    if(currIndex > 96 && currIndex < 123) return Convert.ToString((char)currIndex);
                    i--;
                 }
            }
            else if(wordCount<10 && wordCount>k){
                for(int j=0;j<=i;j++){
                    currIndex = (int)s[j];
                    if(currIndex > 96 && currIndex < 123){
                        result += s[j];
                    }
                    else{
                        times = currIndex - 48;
                        result = helper(result, times);
                    }    
                }
                return Convert.ToString(result[k-1]);
            }
            else if(wordCount>k){
                if(currIndex > 96 && currIndex < 123){
                    wordCount--;
                }
                else{
                    times = currIndex - 48;
                    wordCount = wordCount/times;
                    k = k%((int)wordCount);
                }
            }
        }
        return "";            
    }

    // adds the string multiple times
    public string helper(string s, int tim){
        string result = s;
        while(tim>1){
            result += s;
            tim--;
        }
        return result;
    }
}
