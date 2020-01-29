// Runtime 92 ms -- faster than 81.65%
// Memory 24.6 MB -- less than 5.26%
//
// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if 
// it were inserted in order.
//
// You may assume no duplicates in the array.
public class Solution {

    public int SearchInsert(int[] nums, int target) {
        
        int high = nums.Length - 1;
        int low = 0;

        while (low <= high) {
            int mid = (high + low) / 2;
            int guess = nums[mid];

            if (guess == target) {
                return mid;
            }
            if (guess < target) {
                if (mid == nums.Length - 1) {
                    return nums.Length;
                }
                
                if (nums[mid + 1] > target) {
                    return mid + 1;
                }
                
                low = mid + 1;
            }
            else {
                if (mid == 0) {
                    return 0;
                }
                
                if (nums[mid - 1] < target) {
                    return mid;
                }
                
                high = mid - 1;
            }
        }
        
        return 0;
    }
}
