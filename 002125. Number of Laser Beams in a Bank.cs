public class Solution {
    public int NumberOfBeams(string[] bank) {
        int n = bank.Length;
        int m = bank[0].Length;
        int pre = 0;
        int curr = 0;
        int result = 0;

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(bank[i][j]=='1'){
                    curr++;
                }
            }
            if(curr!=0){
                result += curr*pre;
                pre = curr;
                curr = 0;
            }
        }

        return result;
    }
}
