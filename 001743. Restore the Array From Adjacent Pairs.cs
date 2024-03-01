public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        int n = adjacentPairs.Length+1;
        int[] result = new int[n];
        Dictionary<int, List<int>> arr = new Dictionary<int, List<int>>();
      // created a list to trackk left and right for each element
        int i=0;
        for(i=0;i<n-1;i++){
            if(arr.ContainsKey(adjacentPairs[i][0])){
                arr[adjacentPairs[i][0]].Add(adjacentPairs[i][1]);
            }
            else{
                arr.Add(adjacentPairs[i][0], new List<int>(){adjacentPairs[i][1]});
            }
            if(arr.ContainsKey(adjacentPairs[i][1])){
                arr[adjacentPairs[i][1]].Add(adjacentPairs[i][0]);
            }
            else{
                arr.Add(adjacentPairs[i][1], new List<int>(){adjacentPairs[i][0]});
            }
        }

      // to get single paired element
        int next = 0;
        foreach(var a in arr){
            if(a.Value.Count==1){
                next = a.Key;
                break;
            }
        }

        i=0;
        result[i++] = next;
        int pre = next;
        next = arr[next][0];
        int currIndex = next;
        result[i++] = next;
        while(i<n){
            if(arr[currIndex][0]==pre){
                next = arr[currIndex][1];
            }
            else{
                next = arr[currIndex][0];
            }
            pre = currIndex;
            result[i++] = next;
            currIndex = next;
        }

        return result;
    }
}
