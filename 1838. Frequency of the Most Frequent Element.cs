public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        List<List<int>> arr = new List<List<int>>();
        int n = nums.Length;
        int cur = 0;
        Array.Sort(nums, (a,b)=>b-a);
        int ind = -1;

        foreach(int a in nums){
            if(cur==a){
                arr[ind][1]++;
            }
            else{
                arr.Add(new List<int>(){a, 1});
                ind++;
                cur = a;
            }
        }

        int maxCount = 0;
        foreach(var a in arr){
            maxCount = Math.Max(maxCount, a[1]);
        }
        int temp = 0;
        int target = 0;
        int len = arr.Count;
        int count = 0;

        for(int i=0;i<len;i++){
            temp = k;
            target = arr[i][0];
            count  = arr[i][1];
            for(int j=i+1;j<len;j++){
                if((target-arr[j][0])*arr[j][1] <= temp){
                    count += arr[j][1];
                    temp = temp - ((target-arr[j][0])*arr[j][1]);
                }
                else{
                    count += temp/(target-arr[j][0]);
                    temp = 0;
                    break;
                }
            }
            maxCount = Math.Max(maxCount, count);
        }


        return maxCount;
    }
}
