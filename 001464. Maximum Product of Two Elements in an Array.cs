public class Solution {
    public int MaxProduct(int[] nums) {
        int fir = 0;
        int sec = 0;
        int n = nums.Length;
        for(int i=0;i<n;i++){
           if(fir < nums[i]){
               if(fir > sec){
                   sec = fir;
               }
               fir = nums[i];
               
           }
           else if(sec < nums[i]){
               sec = nums[i];
           }
        }
        
        return (fir-1)*(sec-1);
    }
}
