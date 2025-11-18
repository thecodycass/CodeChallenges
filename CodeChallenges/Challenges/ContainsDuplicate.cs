namespace CodeChallenges.Challenges;

/*
 * https://neetcode.io/problems/duplicate-integer/question?list=neetcode150
 * 
 * Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
 *
 * Example:
 * Input: nums = [1, 2, 3, 3]
 * Output: true;
 */
public class ContainsDuplicate
{
    private int[] nums = [1, 2, 3, 4, 3, 5];

    public bool HasDuplicate()
    {
        var numMap = new Dictionary<int,int>();
        foreach(var num in nums) {
            if (numMap.ContainsKey(num)) {
                return true;
            }
            numMap[num] = 0;
        }
        return false;
    }
}