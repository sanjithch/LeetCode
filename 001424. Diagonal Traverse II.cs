public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        int n = nums.Count;
        int tlen = 0;
        int ind = 0;
      // to store in Dictionary with i+j values
        Dictionary<int, List<int>> arr = new Dictionary<int, List<int>>();
        for(int i=0;i<n;i++){
            tlen += nums[i].Count;
            for(int j=0;j<nums[i].Count;j++){
                if(arr.ContainsKey(i+j)){
                    arr[i+j].Add(nums[i][j]);   
                }
                else{
                    arr.Add(i+j, new List<int>(){nums[i][j]});
                }
            }
        }

        int[] result = new int[tlen];

        foreach(var a in arr){
            for(int i=a.Value.Count-1;i>=0;i--){
                result[ind++] = a.Value[i];
            }
        }

        return result;
    }
}
