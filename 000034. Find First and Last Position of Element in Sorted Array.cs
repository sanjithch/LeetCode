public class Solution {
  // declared for return format
    int[] result = new int[2];

    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        result[0] = -1;
        result[1] = -1;
        int left = 0;
        int right = n-1;
        int mid = 0;
        int index = -1;

        while(left<=right){
            mid = (left+right)/2;
            if(target==nums[mid]){
                index = mid;
                break;
            }
            else if(nums[mid]>target){
                right = mid-1;
            }
            else{
                left = mid+1;
            }
        }

        //If the target does not exist in the array, will return the default array
        if(index==-1) return result;

        //This helps to get the left and right index targets in the array
        helper(nums, target, index, n);
        return result;
    }


  
    public void helper(int[] nums, int target, int index, int n){
        int left = 0;
        int right = index;
        int mid = 0;
      // checks in the array towards the left
        while(left<=right){
            mid = (left+right)/2;
            if(nums[mid]==target && (mid==0 || (mid>0 && nums[mid-1]<target))){
                result[0] = mid;
                break;
            }
            else if(nums[mid]==target){
                right = mid-1;
            }
            else if(nums[mid]<target){
                left = mid+1;
            }
        }

        // check will vary the right part of the known array
        left = index;
        right = n-1;
      // checks in the array towards the right
        while(left<=right){
            mid = (left+right)/2;
            if(nums[mid]==target && (mid==n-1 || (mid<n-1 && nums[mid+1]>target))){
                result[1] = mid;
                break;
            }
            else if(nums[mid]==target){
                left = mid+1;
            }
            else if(nums[mid]>target){
                right = mid-1;
            }
        }
    }
}
