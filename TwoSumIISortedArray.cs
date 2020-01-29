// Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
//
// The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.
public class Solution {
    
    // use a two-pointer algorithm. Time complexity O(n)
    public int[] TwoSum(int[] numbers, int target) {
        
        int low = 0;
        int high = numbers.Length - 1;
        
        while (low < high) {
            int sum = numbers[low] + numbers[high];
            
            if (sum == target) {
                return new int[2]{low + 1, high + 1}; // question says returned indexes should not be zero based
            }
            else if (sum < target) {
                low++;
            }
            else {
                high--;
            }
        }
        
        // question says every array has a solution so should never get here
        throw new Exception("No solution found");
    }
}
