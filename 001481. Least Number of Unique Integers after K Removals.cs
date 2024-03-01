public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int, int> arr1 = new Dictionary<int, int>();

        foreach(int val in arr){
            if(arr1.ContainsKey(val)){
                arr1[val]++;
            }else{
                arr1.Add(val, 1);
            }
        }

        int[] freq = arr1.Values.ToArray();
        Array.Sort(freq);

        int i=0;

        while(k>0 && i<freq.Length){
            k -= freq[i];
            if(k>=0){
                i++;
            }
            else{
                break;
            }
        }

        return freq.Length-i;
    }
}
