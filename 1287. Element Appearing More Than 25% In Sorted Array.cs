public class Solution {
    public int FindSpecialInteger(int[] arr) {
        int n = arr.Length;
      // estimating the minimum repeating length of the number
        int p25 = (arr.Length)/4;
        for(int i=0;i<n-p25;i++){
            if(arr[i]==arr[p25+i]) return arr[i];
        }

        return 0;
    }
}
