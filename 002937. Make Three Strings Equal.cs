public class Solution {
    public int FindMinimumOperations(string s1, string s2, string s3) {
        int len = Math.Min(Math.Min(s1.Length, s2.Length), s3.Length);
        int count = 0;
        for(int i=0;i<len;i++){
             if(s1[i]==s2[i] && s2[i]==s3[i]){
                 count++;
             }
            else{
                break;
            }
        }
        int sumOfLength = s1.Length + s2.Length + s3.Length;
        
        if(count==0) return -1;
        return sumOfLength-3*count;
    }
}
