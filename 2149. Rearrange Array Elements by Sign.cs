public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int n = nums.Length;

        int[] result = new int[n];
        int posi = 0;
        int negi = 1;
        foreach(int val in nums){
            if(val>0){
                result[posi] = val;
                posi += 2;
            }else{
                result[negi] = val;
                negi += 2;
            }
        }
        
        return result;
    }
}
