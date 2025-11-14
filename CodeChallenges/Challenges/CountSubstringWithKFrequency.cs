namespace CodeChallenges.Challenges;

/*
 * https://leetcode.com/problems/count-substrings-with-k-frequency-characters-i/description/
 * 
 * Given a string s and an integer k, return the total number of substrings of s where
 * at least one character appears at least k times.
 *
 * Input: s = "abacb", k = 2
 * Output: 4
 * Explanation:
 * The valid substrings are:
 * "aba" (character 'a' appears 2 times).
 * "abac" (character 'a' appears 2 times).
 * "abacb" (character 'a' appears 2 times).
 * "bacb" (character 'b' appears 2 times).
 */
public class CountSubstringWithKFrequency()
{
    public const string S = "abacb";
    public const int K = 2;

    public int GetSubstringCoundWithKFrequency()
    {
        var left = 0;
        var frequency = 0;
        
        for (var right = 0; right < S.Length; right++)
        {
            
        }
        return 0;
    }
}