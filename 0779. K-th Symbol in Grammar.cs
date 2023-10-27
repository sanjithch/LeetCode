class Solution {
    public int kthGrammar(int n, int k) {
        if(n==1) return 0;
        // checks how many negations to be made
        //We can use the advantage of principle, negating twice 0 or 1 will result in the same number
        boolean numNeg = true;
        while(n>2){
            if(k%2==0) numNeg = !numNeg;
            k = k/2+k%2;
            n--;
        }
      // reaches the first level
        if(k==1)
        {
            if(numNeg) return 0;
            return 1;
        }
        else
        {
            if(numNeg) return 1;
            return 0;
        }
    }
}
