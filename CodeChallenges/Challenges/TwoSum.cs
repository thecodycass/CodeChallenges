namespace CodeChallenges.Challenges;

/*
 * https://leetcode.com/problems/two-sum/description/
 *
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 *
 * Input: nums = [2,7,11,15], target = 9
   Output: [0,1]
   Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 */
public class TwoSum
{
  private readonly int[] _nums = [2, 7, 11, 15];
  private const int Target = 9;

  public int[] GetTwoSum()
  {
    var numMap = new Dictionary<int, int>(){}; // Store Compliment and index location
    
    for (var i = 0; i < _nums.Length; i++)
    {
      var currNum = _nums[i];
      var compliment = Target - currNum;

      while (numMap.ContainsKey(compliment))
      {
        return new int[] { numMap[compliment], i };
      }

      numMap.Add(currNum, i); // Add new 
    }
    return Array.Empty<int>();
  }
}
