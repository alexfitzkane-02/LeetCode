public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
       if(strs is null || strs.Length == 0)
        {
            return "";
        }

        else
        {
            string firstWord = strs[0];
            for(int i = 0; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(firstWord) != 0)
                {
                    firstWord = firstWord.Substring(0, firstWord.Length - 1);
                    if(string.IsNullOrWhiteSpace(firstWord)) return "";
                }
            }

            return firstWord;
        }
    }
}