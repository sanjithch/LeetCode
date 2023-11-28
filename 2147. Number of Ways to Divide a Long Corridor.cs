public class Solution {
    public int NumberOfWays(string corridor) {
        int n = corridor.Length;
        long mod = 1000000007;
      // to store the array values
        int[] arr = new int[n];
      // for compiling the result 
        int preResult =  0;
        int totalChairs = 0;
        string s = corridor;
        for(int i=0;i<n;i++){
            if(s[i]=='S'){
                totalChairs++;
            }
            arr[i] = totalChairs;
        }

        if(totalChairs%2==1 || totalChairs<2) return 0;
        if(totalChairs==2) return 1;

        long result = 1;
        long count = 1;
        for(int i=0;i<n;i++){
            count = 1;
            if(arr[i]%2==0 && arr[i]!=0){
                i++;
                preResult = (int)result;
                while(i<n && arr[i]%2!=1){
                    count++;
                    i++;
                }
                result = (long)(result*count)%mod;
                i--;
            }
        }
        return preResult;
    }
}
