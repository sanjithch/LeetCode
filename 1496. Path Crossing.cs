public class Solution {
    public bool IsPathCrossing(string path) {
        int n = path.Length;
        HashSet<(int,int)> arr = new HashSet<(int, int)>(){(0,0)};
        int x = 0;
        int y = 0;
        for(int i=0;i<n;i++){
            if(path[i]=='N') y++;
            else if(path[i]=='W') x--;
            else if(path[i]=='E') x++;
            else if(path[i]=='S') y--;
            if(arr.Contains((x, y))) return true;
            arr.Add((x,y));
        }

        return false;
    }
}
