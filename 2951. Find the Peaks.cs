public class Solution {
    public IList<int> FindPeaks(int[] mountain) {
        List<int> result = new List<int>();
        int n = mountain.Length;
        
        for(int i=1;i<n-1;i++){
            if(mountain[i-1] < mountain[i] && mountain[i] > mountain[i+1]) result.Add(i);
        }
        return result;
    }
}
