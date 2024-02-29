public class Solution {
    public bool IsPowerOfTwo(int n) {
        int temp = n;
        int rem = 0;
        if(n<1) return false;
        while(temp>0){
            rem = rem | temp%2;
            temp = temp/2;
            if(temp > 0 && rem == 1){
                return false;
            }
        }

        return true;
    }
}
