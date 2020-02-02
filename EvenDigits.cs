// Runtime 96ms -- faster than 70.78%
//
// Given an array nums of integers, return how many of them contain an even number of digits. 
//
public class Solution {
    public int FindNumbers(int[] nums) {
        int even = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            int digits = 0;
            while (nums[i] > 0) {
                nums[i] = nums[i] / 10;
                digits++;
            }
            
            if (digits % 2 == 0) {
                even++;
            }
        }
        
        return even;
    }
}
