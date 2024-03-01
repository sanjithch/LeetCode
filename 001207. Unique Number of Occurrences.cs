public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        int n = arr.Length;
        Array.Sort(arr);
        HashSet<int> hash = new HashSet<int>();

        int curr = arr[0];
        int count = 1;

        for(int i=1;i<n;i++){
            if(curr==arr[i]){
                count++;
            }else{
                if(hash.Contains(count)){
                    return false;
                }
                curr = arr[i];
                hash.Add(count);
                count = 1;
            }
        }
        if(hash.Contains(count)){
            return false;
        }
        hash.Add(count);
        return true;
    }
}
