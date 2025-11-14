namespace CodeChallenges.Challenges;

/**
 * https://leetcode.com/problems/binary-search/description/
 *
 * Given an array of integers nums which is sorted in ascending order, and an integer target,
 * write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
 *
 *  ### You must write an algorithm with O(log n) runtime complexity. ###
 *
 * Example:
 * Input: nums = [-1,0,3,5,9,12], target = 9
 * Output: 4
 * Explanation: 9 exists in nums and its index is 4
 */
public class BinarySearch
{
    private int[] nums = [-1, 0, 3, 5, 9, 12];
    private int target = 9;

    public int GetBinarySearch()
    {
        // To do this, we will need to literally use a binary search... hence the name
        var length = nums.Length;
        var left = 0;
        var right = length - 1;
        
        while (left <= right)
        {
            // Find the mid-point of the spread between left and right.
            var mid = left + (right - left) / 2;

            if (nums[mid] > target)
            {
                right = mid - 1;
            } else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        // If not found
        return -1;
    }
}