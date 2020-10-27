/// Problem:
/// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
/// Return the running sum of nums.
public class Solution {
    public int[] RunningSum(int[] nums) {
     
        int[] result = new int[nums.Length];
        
        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            result[i] = sum + nums[i];
            sum = result[i];
        }
        
        return result;
        
    }
}
