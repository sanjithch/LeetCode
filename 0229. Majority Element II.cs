public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> result = new List<int>();
        int n = nums.Length;
        int majorityCount = n/3+1;
        int count = 1;

        Array.Sort(nums);

        for(int i=0;i<n-1;i++){
            if(nums[i]==nums[i+1]){
                count++;
            }
            else{
                if(count>=majorityCount){
                    result.Add(nums[i]);
                }
                count=1;
            }
        }

        if((majorityCount==1 || majorityCount<=count) && (result.Count==0 || result[result.Count-1]!=nums[n-1])){
            result.Add(nums[n-1]);
        }

        return result;
    }
}
