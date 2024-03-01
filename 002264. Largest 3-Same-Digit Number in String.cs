public class Solution {
    public string LargestGoodInteger(string num) {
        int max = -1;
        string result = "";
        for(int i=0;i<num.Length-2;i++){
            if(num[i]==num[i+1] && num[i+1]==num[i+2]){
                if(max < num[i]-'0'){
                    max = num[i]-'0';
                }
            }
        }
        if(max!=-1) result = ""+max+max+max;
        return result;
    }
}
