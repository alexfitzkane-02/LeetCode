public class Solution 
{
    private static readonly Dictionary<char, int> RomanMapping = new()
      {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
      };
      
    public int RomanToInt(string s) 
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        int total = 0;
        int lastValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char current = char.ToUpper(s[i]); 
            
            if (!RomanMapping.TryGetValue(current, out int currentValue))
            {
                throw new ArgumentException($"Invalid Roman numeral character: {s[i]}");
            }

            if (currentValue < lastValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
                lastValue = currentValue;
            }
        }

        return total;
    }
}