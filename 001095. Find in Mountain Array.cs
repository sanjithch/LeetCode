/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int peak = 0;
        int left = 0;
        int n = mountainArr.Length();
        int right = n-1;
        int mid = (left+right)/2;
        int leftSide = 0;
        int rightSide = 0;
        int middle = 0;

      // getting the peak in the moutain
        while(left<right-1){
            mid = (left+right)/2;
            leftSide = mountainArr.Get(mid-1);
            middle = mountainArr.Get(mid);
            rightSide = mountainArr.Get(mid+1);
            if(leftSide < middle && middle > rightSide){
                peak = mid;
                break;
            }
            else if(leftSide < middle && middle < rightSide){
                left = mid;
            }
            else{
                right = mid;
            }
        }
      
        if(target == mountainArr.Get(peak)) return peak;

        left = 0;
        right = peak;

       // searching in the uphill
        while(left<=right){
            mid = (left+right)/2;
            middle = mountainArr.Get(mid);
            if(target == middle){
                return mid;
            }else if(target < middle) {
                right = mid-1;
            }else{
                left = mid+1;
            }
        }

        left = peak;
        right = n-1;
      
       // searching in downhill
        while(left<=right){
            mid = (left+right)/2;
            middle = mountainArr.Get(mid);
            if(target == middle){
                return mid;
            }else if(target > middle) {
                right = mid-1;
            }else{
                left = mid+1;
            }
        }

        return -1;
    }
}
