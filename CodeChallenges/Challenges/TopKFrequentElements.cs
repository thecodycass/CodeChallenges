namespace CodeChallenges.Challenges;

/*
 * https://neetcode.io/problems/top-k-elements-in-list/question?list=neetcode150
 *
 * Given an integer array nums and an integer k, return the k most frequent elements within the array.
 * The test cases are generated such that the answer is always unique.
 * You may return the output in any order.
 *
 * Input: nums = [1,2,2,3,3,3], k = 2
 * Output: [2,3]
 */
public class TopKFrequentElements
{
    private int[] _nums = [1, 2, 2, 3, 3, 3];
    private int _k = 2;

    public int[] Solution()
    {
        var dups = new HashSet<int>();
        var numMap = new Dictionary<int, int>();
        foreach (var num in _nums)
        {
            if (!numMap.ContainsKey(num))
            {
                numMap.TryAdd(num, 1);
            }
            else
            {
                numMap[num]++;
            }
            
            if (numMap[num] == _k) dups.Add(num);
        }
        return dups.ToArray();
    }
}