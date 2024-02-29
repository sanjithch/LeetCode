public class Solution {
    public long LargestPerimeter(int[] nums) {
        int n = nums.Length;
        long[] arr = new long[n];
        Array.Sort(nums);

        arr[0] = nums[0];
        for(int i=1;i<n;i++){
            arr[i] = arr[i-1]+nums[i];
        }

        for(int i=n-1;i>=2;i--){
            if(nums[i]<arr[i-1]){
                return arr[i];
            }
            
        }

        return -1;
    }
}
