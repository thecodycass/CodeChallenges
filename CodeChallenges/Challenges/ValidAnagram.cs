namespace CodeChallenges.Challenges;

public class ValidAnagram
{
    private readonly string _s = "rocecor";
    private readonly string _t = "corroce";
    
    public bool IsAnagram()
    {
        if (_s.Length != _t.Length) return false;

        /*
         * To solve this, I am going to create an array of ints being at least 26 indices long.
         *  -- NOTE: The number 26 is the count of how many letters are in the alphabet.
         *
         * I'm just going to increment and decrement the current char in that's selected, and compare them.
         *  -- NOTE: chars are converted to ints when operations are done using them in certain ways.
         *  Since ALL the letters will be the same eventually, then that means it will ALWAYS perfectly return all zeros, or be false.
         */
        var counts = new int[26];

        for (var i = 0; i < _s.Length; i++)
        {
            // This will always EVENTUALLY equal zero's if ALL letters in each word will == the same at the end.
            counts[_s[i] - 'a']++;
            counts[_t[i] - 'a']--;
        }

        // All counts should return to zero
        foreach (var count in counts)
            if (count != 0)
                return false;

        return true;
    }
}