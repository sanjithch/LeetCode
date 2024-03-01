public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        Console.WriteLine(n);
        while(n>0){
            if(n%2==1) count++;
            n=n/2;
        }

        return count;
    }
}
