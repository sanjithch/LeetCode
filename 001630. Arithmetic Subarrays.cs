public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
     int n = nums.Length;
     int m = l.Length;
     List<bool> result = new List<bool>();
     for(int i=0;i<m;i++){
       // creating a new array for storing the values from main array
        int[] arr = new int[r[i]-l[i]+1];
        for(int j=l[i];j<=r[i];j++){
            arr[j-l[i]] = nums[j];
        }
        result.Add(helper(arr));
     }   

     return result;
    }

  // helper method will check the given array is Arthematic or not
    public bool helper(int[] arr){
        Array.Sort(arr);
        int n = arr.Length;
        int dif = arr[1]-arr[0];
        for(int i=1;i<n-1;i++){
            if(arr[i+1]-arr[i]!=dif) return false;
        }

        return true;
    }
}
