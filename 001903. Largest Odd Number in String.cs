public class Solution {
    public string LargestOddNumber(string num) {
        int n = num.Length;
        int ind = -1;

        for(int i=n-1;i>=0;i--){
            if((num[i]-'0')%2==1){
                ind = i;
                break;
            }
        }

        return num.Substring(0,ind+1);
    }
}
