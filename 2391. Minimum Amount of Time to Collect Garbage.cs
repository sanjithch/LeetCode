public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        // M, P, G
      // array store the values for each type of garbage in the above order
        int n = garbage.Length;
        int totalTime = 0;
      // for garbage track
        int[] timesForEachTruck = new int[3];
      // for last homes in queue track
        int[] lastHomes = new int[3];
        int tforD = 0;
        for(int i=0;i<garbage[0].Length;i++){
            if(garbage[0][i]=='M'){
               timesForEachTruck[0]++;
            }
            else if(garbage[0][i]=='P'){
                timesForEachTruck[1]++;
            }
            else if(garbage[0][i]=='G'){
                timesForEachTruck[2]++;
            }
        }

        for(int i=1;i<garbage.Length;i++){
            tforD += travel[i-1];
            for(int j=0;j<garbage[i].Length;j++){
                if(garbage[i][j]=='M'){
                  timesForEachTruck[0]++;
                  //gets the last home and assign it in lasHomes array
                  lastHomes[0] = tforD;
                }
                else if(garbage[i][j]=='P'){
                    timesForEachTruck[1]++;
                    lastHomes[1] = tforD;
                }
                else if(garbage[i][j]=='G'){
                    timesForEachTruck[2]++;
                    lastHomes[2] = tforD;
                }
            }
        }
      // adding all the times
        totalTime = timesForEachTruck[0]+timesForEachTruck[1]+timesForEachTruck[2]+lastHomes[0]+lastHomes[1]+lastHomes[2];

        return totalTime;
    }
}
