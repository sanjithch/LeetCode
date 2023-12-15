public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        List<string> pick = new List<string>();
        List<string> dest = new List<string>();
        for(int i=0;i<paths.Count;i++) {
            pick.Add(paths[i][0]);
            dest.Add(paths[i][1]);
        }
        int ind = -1;
        foreach(string s in pick){
            ind = containsHelper(s, dest);
            if(ind<0){
                continue;
            }
            dest.RemoveAt(ind);
        }

        return dest[0];
    }

    public int containsHelper(string s, List<string> dest){
        int i=0;
        for(i=0;i<dest.Count;i++){
            if(s==dest[i]) return i;
        }
        return -1;
    }
}
