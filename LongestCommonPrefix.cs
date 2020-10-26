/// Problem
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
///
/// Solution
/// Takes the shortest string in strs. Loops through each letter of the shortest string and compares it to the same index in the other strings. If one they all match append that char 
/// to result string. If they don't match return result string.
/// Runtime : 100ms (faster than 77%)
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        if (strs.Length == 0)
            return "";
        
        // find shortest string
        string shortest = strs[0];
        foreach (string s in strs) {
            if (s.Length < shortest.Length) {
                shortest = s;
            }
        }
        
        string result = "";
        for (int i = 0; i < shortest.Length; i++) {
            // check each strs[i] matches the length of our shortest string
            char target = shortest[i];
            // inefficient since we'll be comparing an element to itself
            foreach(string s in strs) {
                if (s[i] != target)
                    return result;
            }
            result += target;
        }
        
        return result;
    }
}
