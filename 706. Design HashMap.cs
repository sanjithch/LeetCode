public class MyHashMap {

    Dictionary<int, int> myDict;

    public MyHashMap() {
        myDict = new Dictionary<int, int>();
    }
    
    public void Put(int key, int value) {
        if(myDict.ContainsKey(key)){
            myDict[key] = value;
        }
        else{
            myDict.Add(key, value);
        }
    }
    
    public int Get(int key) {
        if(!myDict.ContainsKey(key)) return -1;
        return myDict[key];
    }
    
    public void Remove(int key) {
        if(myDict.ContainsKey(key))
           myDict.Remove(key);
    }
}
