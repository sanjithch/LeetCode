public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        int n = nums.Length;
        int[] hash = new int[101];
        int max = 0;

        foreach(int a in nums){
            hash[a]++;
            if(hash[a]>max){
                max = hash[a];
            }
        }

        int count = 0;
        foreach(int a in hash){
            if(max==a) count++;
        }

        return count*max;
    }
}
