public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int n1  = nums1.Length;
        int n2  = nums2.Length;

        int left = 0;
        int right = 0;

        while(left<n1 && right<n2){
            if(nums1[left]==nums2[right]){
                return nums1[left];
            }else if(nums1[left]>nums2[right]){
                right++;
            }else{
                left++;
            }
        }

        return -1;
    }
}
