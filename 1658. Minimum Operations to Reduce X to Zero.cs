//This problem is a fun challenge to go along
public class Solution {
    public int MinOperations(int[] nums, int x) {
        int n = nums.Length;
        int MinimumCount = -1;
        int count = 0;
        int[] left = new int[n+1];
        int[] right = new int[n+1];
        left[1] = nums[0];
        right[n-1] = nums[n-1];

      // getting the cumulative sums from left and right to use it for iteration
        for(int i=1;i<n;i++){
            left[i+1] = left[i]+nums[i];
            right[n-i-1] = right[n-i]+nums[n-i-1];
        }
       
        for(int j=n;j>=0;j--){
            if(right[j]>x) break;
            //  gets the index of the element on the right - how many digits I can include from the right
            int index = binaryHelper(right[j], x, left, n, j);
            if(index!=-1){
                count = index+n-j;
                if(MinimumCount==-1)
                    MinimumCount = count;
                else
                    MinimumCount = Math.Min(MinimumCount, count);
            }
        }
        return MinimumCount;
    }

  //With binary search I get the right number digits I can Inculde from right
    public int binaryHelper(int boost, int target, int[] num, int n, int reach){
        int left = 0;
        int right = reach;
        while(left<=right){
            int mid = (left+right)/2;
            if(boost+num[mid]==target) return mid;
            else if(boost+num[mid]>target) right = mid-1;
            else left = mid+1;
        }
        return -1;
    }
}
