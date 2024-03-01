class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        vector<vector<string>> result;
        
        int n = strs.size();
        
        if(n==1){
            result.push_back(strs);
            return result;
        }
        
        bool isVisited[n];
        memset(isVisited, 0, sizeof(isVisited));
        
        int arr[n+1][26];
        memset(arr, 0, sizeof(arr));
        
        
        for(int i=0;i<n;i++){
            for(int j=0;j<strs[i].size();j++){
                arr[i][strs[i][j]-'a']++;
            }
        }
        
        vector<string> temp;
        for(int i=0;i<n;i++){
            if(!isVisited[i]){
                temp.push_back(strs[i]);
                isVisited[i] = true;
                for(int j=i+1;j<n;j++){
                    if(!isVisited[j]){
                    if(strs[i].size()!=strs[j].size()){
                        continue;
                    }
                    int k = 0;
                        for(k=0;k<strs[i].size();k++){
                            if(arr[i][strs[i][k]-'a']!=arr[j][strs[i][k]-'a'])
                                break;
                        }
                    /*for(;k<26;k++){
                        if(arr[i][k]!=arr[j][k])
                            break;
                    }*/
                    if(k==strs[i].size()){
                        isVisited[j]=true;
                        temp.push_back(strs[j]);
                    }
                   }
                }
                result.push_back(temp);
                temp.clear();
            }
        }
        return result;
    }
};
