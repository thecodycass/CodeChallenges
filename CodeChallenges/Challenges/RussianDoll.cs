namespace CodeChallenges.Challenges;

/*
 * https://leetcode.com/problems/russian-doll-envelopes/
 *
 * You are given a 2D array of integers envelopes where envelopes[i] = [wi, hi] represents the width and the height of an envelope.
 * One envelope can fit into another if and only if both the width and height of one envelope are greater than the other envelope's width and height.
 * Return the maximum number of envelopes you can Russian doll (i.e., put one inside the other).
 *
 * Note: You cannot rotate an envelope.
 *
 * Example 1:
 * Input: envelopes = [[5,4],[6,4],[6,7],[2,3]]
 * Output: 3
 *
 * Explanation: The maximum number of envelopes you can Russian doll is 3 ([2,3] => [5,4] => [6,7]).
 */
public class RussianDoll
{
    private readonly int[][] envelopes = [[1,3],[3,5],[6,7],[6,8],[8,4],[9,5]]; // The value is a great edge case to use
    
    /*
     * [[5,4],[6,4],[6,7],[2,3]]
     * We can see that the pattern is:
     * [2,3] -> [5,4] -> [6,7] which represents the output of 3
     */
    public int GetRussianDollEnvelopes()
    {
        if (envelopes.Length == 0) return 0;

        // 1. Sort by width ASC, and for equal widths, height DESC
        ReverseSort();

        // 2. Extract heights and run LIS on them
        var envelopesLength = envelopes.Length;
        var tails = new int[envelopesLength];
        var len = 0; // Counter length

        for (var i = 0; i < envelopesLength; i++)
        {
            var height = envelopes[i][1];

            // Binary search on tails[0...len)
            var left = 0;
            var right = len;
            while (left < right)
            {
                /*
                 * (right - left) to find the distance
                 * Add that to left and divide by 2 to get the mid-point from left to len.
                 */
                var mid = left + (right - left) / 2;
                /* If the mid-point value is smaller than the tallest found height, we move the left to the mid-point
                 * since we know the numbers from the mid-point and to the start are smaller than the height.
                 */
                if (tails[mid] < height)
                    left = mid + 1;
                else
                    // If the mid-point is greater than the current height, we can move right.
                    right = mid;
            }

            tails[left] = height;
            if (left == len) len++;
        }

        return len;
    }

    private void ReverseSort()
    {
        var width = 0;
        var height = 1;
        Array.Sort(envelopes, (a, b) =>
        {
            if (a[width] == b[width]) // Check width
            { 
                return b[height].CompareTo(a[height]); // Compare height descending
            }
            return a[width].CompareTo(b[width]); // Compare width ascending
        });
    }
}