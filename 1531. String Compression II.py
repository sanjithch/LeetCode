class Solution:
    def getLengthOfOptimalCompression(self, s: str, k: int) -> int:

        cache = {}
        def count(i, k, prev, prev_count) -> int:
            if(i, k, prev, prev_count) in cache:
                return cache[(i, k, prev, prev_count)]
            if k < 0:
                return len(s)-k
            if len(s) - i == k:
                return 0


            if s[i]==prev:
                inc = 1 if prev_count in [1, 9, 99] else 0
                ans = inc + count(i+1, k, prev, prev_count+1)
            else:
                ans = min(
                    count(i+1, k-1, prev, prev_count),
                    1+count(i+1, k, s[i], 1)
                )

            cache[i, k, prev, prev_count] = ans
            
            return ans

        return count(0, k, "", 0)
        
