/// Problem
/// Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
/// For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. 
/// Notice that multiple kids can have the greatest number of candies.
///
/// Solution
/// Uses two loops on candies; the first determines the max value in candies, the seconds checks whether each element added to extraCandies would be greater than max value.
public class Solution {
    
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>(candies.Length);
        
        // get largest element
        int largest = 0;
        foreach(int i in candies) {
            if (i > largest)
                largest = i;
        }
        
        foreach(int i in candies) {
            result.Add(i + extraCandies >= largest);
        }
        
        return result;
    }
}
