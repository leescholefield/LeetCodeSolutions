// Problem
// Given a string s, find the length of the longest substring without repeating characters.
public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        
        int i = 0;
        int j = 0;
        
        List<char> substring = new List<char>();
        while (i < s.Length && j < s.Length) {
            
            if (substring.Contains(s[j])) {
                if (substring.Count > result) {
                    result = substring.Count;
                }
                substring.Remove(s[i]);
                i++;
            }
            else {
                substring.Add(s[j]);
                j++;
            }
        }
        
        return substring.Count > result ? substring.Count : result;
    }
}
