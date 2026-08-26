public class Solution {
    public bool IsPalindrome(int x) {
        int[] digits = x.ToString()
                            .Select(a => (int)Char.GetNumericValue(a))
                            .ToArray();
                
        int[] digitsReversed = digits.Reverse().ToArray();

        for(int i = 0; i < digits.Length; i++)
        {
            if(digits[i] == digitsReversed[i])
            {
                continue;
            }

            else return false;
        }

        return true;
      
    }
}