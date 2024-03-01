public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int n = nums.Length;
        int result = 0;

        //to store values for each integer
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        for(int i=0;i<n;i++){
            if(myDict.ContainsKey(nums[i])){
                myDict[nums[i]]++;
            }
            else{
                myDict.Add(nums[i], 1);
            }
        }

        foreach(var a in myDict){
            result += (a.Value*(a.Value-1))/2;
        }
        return result;
    }
}
