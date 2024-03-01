// with Functional Programming

public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        return mat.Select((row, i) => (sum: row.Sum(), i)) // took each row and selected its sum
                .OrderBy(row => row.sum) //ordered it by sum
                .Select(row => row.i)// selected its indexes
                .ToArray()[..k];// selected first k elements
    }
}
