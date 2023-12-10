public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        List<int> arr = new List<int>();
        int max = 0;
        
        for(int i=0;i<nums.Length;i++){
         max = Math.Max(max, nums[i]);   
        }
        
        // Console.WriteLine(max);
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==max) arr.Add(i);
        }
        
        if(k>arr.Count) return 0;
        
        long result = 0;
        // length of the repetition
        int lenRep = arr.Count;
        int arrInd = arr[0];
        
        int maxLost = 0;
        int n = nums.Length;
        for(int i=0;i<nums.Length;i++){
             result += n - arr[maxLost+k-1];
             if(arrInd==i){
               maxLost++;
               if(lenRep-maxLost<k) break;
               arrInd = arr[maxLost];
            }
            // Console.WriteLine(i + " " + result);
        }
        
        return result;
    }
}
