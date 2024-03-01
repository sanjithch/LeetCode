public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> arr = new Dictionary<char, int>();

        for(int i=0;i<s.Length;i++){
            if(arr.ContainsKey(s[i])){
                arr[s[i]]++;
            }else{
                arr.Add(s[i], 1);
            }
        }

        StringBuilder result = new StringBuilder();

        foreach(var item in arr.OrderByDescending(key => key.Value)){
            int temp = item.Value;
            while(temp>0){
                result.Append((char)(item.Key));
                temp--;
            }
        }

        return result.ToString();
    }
}
