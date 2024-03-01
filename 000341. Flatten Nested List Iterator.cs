/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
   // to add values to the list
    List<int> arr = new List<int>();
    int ind = 0;

    public NestedIterator(IList<NestedInteger> nestedList) {
        helper(nestedList);
    }

    // created a recursive method to loop through the nestedList
    public void helper(IList<NestedInteger> nestedList){
        int len = nestedList.Count;
        for(int i=0;i<len;i++){
            if(nestedList[i].IsInteger()){
                arr.Add(nestedList[i].GetInteger());
            }
            else{
                helper(nestedList[i].GetList());
            }
        }

    }

    public bool HasNext() {
        // only true until the length of the list
        if(ind<arr.Count) return true;
        return false;
    }

    // return an Integer, then points the incremented index
    public int Next() {
        return arr[ind++];
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
