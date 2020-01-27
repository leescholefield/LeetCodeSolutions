// runtime 248ms -- faster than 34.67%
// memory usage 30.2Mb -- less than 11.11%
//
// Problem:
// Given an array nums and a value toRemove, remove all instances of that value in-place and return the new length.
public class Solution {
    
    public int RemoveElement(int[] nums, int toRemove) {
        int count = 0;
        for (int j = 0; j < nums.Length; j++) {
            if (nums[j] != toRemove)  {
                nums[count] = nums[j];
                count++;
            }
        }
        
        return count;
    }
}
