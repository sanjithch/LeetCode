public class Solution {
    public int[] SortByBits(int[] arr) {
        int n = arr.Length;
        int[] calBits = new int[n];
      
      // store the bits to avoid recalculation
        for(int i=0;i<n;i++){
            calBits[i] = calBitHelp(arr[i]);
        }

        int temp = 0;

        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                // needs change if true, we need to change its assoiciated bits also
                if(helper(arr[i], arr[j], calBits[i], calBits[j])){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    temp = calBits[i];
                    calBits[i] = calBits[j];
                    calBits[j] = temp;
                }
            }
        }

        // Array.Sort(arr, (a,b) => helper(a,b));
        return arr;
    }

  // calculates the bits 
    public int calBitHelp(int before){
         int bb = 0;
        while(before > 0){
            bb += before%2==0 ? 0 : 1;
            before /=2;
        }
        return bb;
    }

  // return true if it needs change
    public bool helper(int before, int after, int bb, int ab){
        if(ab < bb) return true;
        else if(ab > bb) return false;
        if(before > after) return true;
        return false;
    }
}
