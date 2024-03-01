public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
      //Sorting the array using an array using strings
        Array.Sort(nums, (a,b) => String.Compare(a,b));
        int curr = 0;
        int len = nums.Length;
        for(int i=0;i<len;i++){
            if(getMeNum(nums[i])==curr){
                curr++;
                continue;
            }
            return makeString(curr, nums[i].Length);
        }
        return makeString(curr, nums[0].Length);
    }

  // making the string from the given
    public string makeString(int curr, int len){
        string result = "";
        while(curr>0){
            result = curr%2 + result;
            curr /= 2;
        }
        len = len - result.Length;
        while(len-->0) result = "0"+result;
        return result;
    }

    public int getMeNum(string s){
        int len = s.Length;
        int num = 0;
        for(int i=0;i<len;i++){
            num = num*2+(int)(s[i]-'0');
        }
        return num;
    }
}
