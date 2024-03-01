public class Solution {
    public int LongestStrChain(string[] words) {
        int n = words.Length;
        int maxWordLen = 0;
        for(int i=0;i<n;i++) maxWordLen = Math.Max(maxWordLen, words[i].Length);

        List<string>[] arr = new List<string>[maxWordLen];
        List<int>[] count = new List<int>[maxWordLen];
        for(int i=0;i<maxWordLen;i++){
            arr[i] = new List<string>();
            count[i] = new List<int>();
        }

        for(int i=0;i<n;i++){
            arr[(words[i].Length)-1].Add(words[i]);
            count[(words[i].Length)-1].Add(1);
        }

         int result = 1;

        for(int i=1;i<maxWordLen;i++){
            for(int j=0;j<arr[i].Count;j++){
                for(int k=0;k<arr[i-1].Count;k++){
                    if(helper(arr[i-1][k], arr[i][j])){
                        count[i][j] = Math.Max(count[i][j], 1+count[i-1][k]);
                        result = Math.Max(count[i][j], result);
                    }
                }
            }
        }

        return result;
    }

    public bool helper(string a, string b){
        int n = b.Length;
        int i = 0;
        int j = 0;
        while(i<n-1 && j<n){
            if(a[i]==b[j]){
                i++;
            }
            j++;
        }
        if(i==n-1) return true;
        else return false;
    }
}
