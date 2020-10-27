/// Problem:
/// Given a string s and an integer array indices of the same length.
/// The string s will be shuffled such that the character at the ith position moves to 
/// indices[i] in the shuffled string.
/// Return the shuffled string.
/// 
/// Runtime: 112 ms (faster than 55%)
public class Solution {
    public string RestoreString(string s, int[] indices) {
     
        char[] resultArray = new char[s.Length];
        
        for (int i = 0; i < indices.Length; i++) {
            int index = indices[i];
            resultArray[index] = s[i];
        }
        
        return new string(resultArray);
    }
}
