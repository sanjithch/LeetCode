public class Solution {
    // for global access
    string str;
    public string LongestPalindrome(string s) {
        string res = ""+s[0];
        str = new String(s);
        int n = s.Length;
        for(int i=0;i<n-1;i++){
            for(int j=n-1;j>i;j--){
              //Use the method helper to check for palindrome
                if(res.Length < (j-i+1) && helper(i, j)){
                    res = s.Substring(i, j+1-i);
                    break;
                }
            }
        }

        return res;
    }

    //helper to check palindrome
    public bool helper(int left, int right){
        while(left<right){
            if(str[left++]!=str[right--]){
                return false;
            }
        }
        return true;
    }
}
