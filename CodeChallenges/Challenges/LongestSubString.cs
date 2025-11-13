namespace CodeChallenges.Challenges;

/*
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
 *
 * Given a string s, find the length of the longest without duplicate characters.
 * Input: s = "abcabcbb"
   Output: 3
   Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
 */
public class LongestSubString(string s = "abcabcbb")
{
    public int GetLongestSubstring()
    {
        var longest = 0; // Stores longest substring count
        var set = new HashSet<char>(); // Stores Substrings
        var left = 0; // Left index of sliding window [left..right]

        for (var right = 0; right < s.Length; right++)
        {
            if (set.Contains(s[right]))
            {
                set.Remove(s[left]); // Remove char from the left slider
                left++; // Increment left slider
            }
            
            set.Add(s[right]); // Add next char in right side of sliding window
            /*
             * Get the count of indices within the sliding window to count the substring
             * +1 on the window to get the actual count since an index starts at 0.
             */
            var window = (right - left) + 1;
            longest = Math.Max(longest, window);
        }

        return longest;
    }
}