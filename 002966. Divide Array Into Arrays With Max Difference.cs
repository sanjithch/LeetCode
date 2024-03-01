public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Length;
        if(helper(nums, n, k)){
            return new int[0][];
        }
        int[][] result = new int[n/3][];
        
        for(int i=0;i<n/3;i++){
            result[i] = new int[3];
        }
        
        int j = 0;
        while(j<n){
            result[j/3][j%3] = nums[j];
            j++;
        }
        
        return result;
    }
    
    public bool helper(int[] nums, int n, int k){
        int ind = 0;
        while(ind<n){
            if(nums[ind+1]-nums[ind]>k || nums[ind+2]-nums[ind]>k){
                return true;
            }
            ind = ind+3;
        }
        return false;
    }
}
