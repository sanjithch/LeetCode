public class Solution {
    public string ReverseWords(string s) {
        int n = s.Length;
        char[] arr = new char[n];
        for(int i=0;i<n;i++) arr[n-i-1] = s[i];
        string res = "";
        string temp = "";
        foreach(var a in arr) {
            if(a==' '){
                res = temp + " "+ res;
                temp = "";
            }
            else{ 
                temp = temp+a;
            }
        }
        res = temp + " "+ res;

        return res.Trim();
    }
}
