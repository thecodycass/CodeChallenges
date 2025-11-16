namespace CodeChallenges.Challenges;

/**
 * https://leetcode.com/problems/valid-parentheses/description/
 *
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 * An input string is valid if:
 *    Open brackets must be closed by the same type of brackets.
 *    Open brackets must be closed in the correct order.
 *    Every close bracket has a corresponding open bracket of the same type.
 *
 * Input: s = "()"
 * Output: true
 *
 * Input: s = "(]"
 * Output: false
 */
public class ValidParentheses
{
    private readonly string s = "(){}[][]()"; // True
    // private readonly string s = "({[])}"; // False
    
    public bool IsValid()
    {
        if (string.IsNullOrEmpty(s)) return false;
        
        /*
         * To solve this in order, we will need to store the brackets to make sure they are in order.
         * This will require LIFO (stack) and we when we receive an opening bracket, we need to push the closing.
         * If the stack is not empty after each iteration, we will know parentheses are out of order.
         */
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c.Equals('(')) stack.Push(')');
            else if (c.Equals('{')) stack.Push('}');
            else if (c.Equals('[')) stack.Push(']');
            else 
            if (stack.Count == 0 || stack.Pop() != c) return false;
        }
        return stack.Count == 0;
    }
}