public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long leftSum = 0;
        long rightSum = 0;
        int leftZeros = 0;
        int rightZeros = 0;
        
        for(int i=0;i<nums1.Length;i++){
            if(nums1[i]==0){
                leftZeros++;
                leftSum++;
            }
            else{
                leftSum += nums1[i];
            }
        }
        
        for(int i=0;i<nums2.Length;i++){
            if(nums2[i]==0){
                rightSum++;
                rightZeros++;
            }
            else{
                rightSum += nums2[i];
            }
        }
        
        long resultSum = 0;
      // check whether left and right are editable
        bool le = leftZeros==0 ? false: true;
        bool re = rightZeros==0 ? false: true;
        if(rightSum<leftSum){
            resultSum = helper(rightSum, leftSum, re, le);
        }
        else{
            resultSum = helper(leftSum, rightSum, le, re);
        }
        
        return resultSum;
    }

  // return the maximum number possible
    public long helper(long min, long max, bool le, bool re){
       if(!le && !re){
           if(min==max) return min;
           return -1;
       }
       if(!le){
           if(min==max) return min;
           return -1;
       }
        
        return Math.Max(min, max);
    }
}
