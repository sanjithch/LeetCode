public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] arr = new int[n];

        int left = 0;
        int right = n-1;
        int mid = 0;

        while(left<=right){
            mid = (left+right)/2;
            if(nums[mid]>=0){
                right = right-1;
            }else{
                left = left+1;
            }
        }

        // Console.WriteLine(mid);
        left = mid-1;
        right = mid;

        int ind = mid;
        int i = 0;

        while(i<n){
            if(right < n && left > -1){
                if(nums[left]*-1 < nums[right]){
                    ind = left--;
                }else{
                    ind = right++;
                }
            }else if(right < n){
                ind = right++;
            }else{
                ind = left--;
            }
            arr[i] = nums[ind]*nums[ind];
            i++;
        }

        return arr;

    }
}
