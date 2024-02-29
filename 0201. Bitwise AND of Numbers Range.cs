public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
     if(left == right) return left;
     
     string lef = "";
     string rig = "";

     while(left > 0){
         lef = left%2 + lef;
         left = left/2;
     }

      while(right > 0){
         rig = right%2 + rig;
         right = right/2;
     }
     if(lef.Length!=rig.Length) return 0;
     int result = 0;
     int po = (int)Math.Pow(2, lef.Length-1);

     for(int i=0;i<lef.Length;i++){
         if(lef[i]==rig[i]){
            if(lef[i]=='1') result += po;
         }
         else{
             break;
         }
         po /= 2;
     }


     return result;
    }
}
