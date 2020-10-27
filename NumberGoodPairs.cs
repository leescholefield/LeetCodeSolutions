/// Problem
/// Given an array of integers nums.
/// A pair (i,j) is called good if nums[i] == nums[j] and i < j.
/// Return the number of good pairs.
/// 
/// Solution:
/// Loop through nums and compair the target to every number to its right; if they are equal 
/// we've found a pair.
/// Runtime: 84ms (faster than 93.74%)
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        
        int pairs = 0;
        
        // no need to check last element
        for (int i = 0; i < nums.Length - 1; i++) {
            int target = nums[i];
            for (int j = i+1; j < nums.Length; j++ ) {
                if (target == nums[j])
                    pairs++;
            }
            
        }        
        return pairs;
        
    }
}
