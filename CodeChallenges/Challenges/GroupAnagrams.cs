namespace CodeChallenges.Challenges;

/*
 * https://neetcode.io/problems/anagram-groups/question?list=neetcode150
 *
 * Given an array of strings strs, group all anagrams together into sublists. You may return the output in any order.
 *
 * An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
 *
 * Input: strs = ["act","pots","tops","cat","stop","hat"]
 * Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]
 */
public class GroupAnagrams
{
    private string[] strs = ["act", "pots", "tops", "cat", "stop", "hat"];
    
    public List<List<string>> Solution()
    {
        var wordMap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var radix = GetStringKey(str);
            if (!wordMap.ContainsKey(radix))
            {
                wordMap[radix] = new List<string>();
            }
            wordMap[radix].Add(str);
        }

        return wordMap.Values.ToList();
    }

    private string GetStringKey(string str)
    {
        // Creates a uniq key
        int[] freq = new int[26];
        foreach(char c in str)
        {
            freq[c - 'a']++;
        }
        return string.Join('#', freq);
    }
}