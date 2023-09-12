public class Solution {
    public int MinDeletions(string s) {
        int n = s.Length;
        int deletions = 0;

       // for mapping lowercase letters and getting their count
        int[] arr = new int[26];
      //for checking if the count already exists in the list
        bool[] count = new bool[n+1];
      
      
        for(int i=0;i<n;i++){
            arr[s[i]-'a']++;
        }//mapped

        int cou = 0;
        for(int i=0;i<26;i++){
            cou = arr[i];
            if(cou==0) continue;
            if(!count[cou]){
                count[cou] = true;
            }
            else{
              while(cou > 0 && count[cou]){
                cou--;
                deletions++;
              }
              if(cou>0){
                  count[cou] = true;
              }
            }
        }
        return deletions;
    }
}
