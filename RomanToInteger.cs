// runs in 96 ms -- faster than 52.29%
// Memory usage 25.8MB -- less than 8.7%

public class Solution {
    
    private static readonly Dictionary<char, int> ValueDict = new Dictionary<char, int>()           {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    public int RomanToInt(string s) {
     
        int total = 0;
        int prevValue = int.MaxValue; // hacky
        
        foreach(char c in s) {
            int val = ValueDict[c];
            
            if (val > prevValue) {
                total += val - (2 * prevValue);
            } 
            else {
                total += val;
            }
            
            prevValue = val;
        }
        
        return total;
    }
}
