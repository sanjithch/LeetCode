public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        // calculate the x and y co-ordinates difference
        int xdif = sx-fx;
        int ydif = sy-fy;
        int px = xdif;
        int py = ydif;

      // if start and end points are same return false
        if(px==0 && py==0 && t==1) return false;
        if(xdif<0){
            px = xdif*-1;
        }
        if(ydif<0){
            py = ydif*-1;
        }
        
        bool isXmin = px<py ? true : false;
        int time = 0;
        
        if(isXmin){
          time = py;
        }
        else{
            time = px;
        }
        
        if(time<=t){
            return true;
        }
        
        return false;
        
        
    }
}
