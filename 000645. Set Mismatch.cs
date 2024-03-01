public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int n = nums.Length;
        bool[] arr = new bool[n];
        int[] result = new int[2];

        foreach(int num in nums){
            if(arr[num-1]){
                result[0] = num;
            }else{
                arr[num-1] = true;
            }
        }

        for(int i=0;i<n;i++){
            if(!arr[i]){
                result[1] = i+1;
            }
        }

        return result;
    }
}
