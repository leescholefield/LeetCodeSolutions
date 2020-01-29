// A peak element is an element that is greater than its neighbors.
//
// Given an input array nums, where nums[i] ≠ nums[i+1], find a peak element and return its 
// index.
//
// The array may contain multiple peaks, in that case return the index to any one of the 
// peaks is fine.
public class Solution {
    
    public int FindPeakElement(int[] nums) {
        
        int low = 0;
        int high = nums.Length - 1;
        
        while (low < high) {
            
            int mid = (low + high) / 2;
            int val = nums[mid];
            if (val > nums[mid + 1]) {
                high = mid;
            }
            else {
                low = mid + 1;
            }
        }
        
        return low;
    }
}
