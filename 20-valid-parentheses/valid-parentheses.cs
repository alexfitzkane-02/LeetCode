public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            // If opening bracket, push it onto the stack
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } 
            // If closing bracket, check for a matching top element
            else {

                if (stack.Count == 0) return false;

                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}