/// Runtime: 328 ms
/// Problem:
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///
/// Solution explanation:
/// This loops thru each element of nums once. For each element it gets the value we want to find in the dictionary (the complement) - this is target - nums[i]. If it exists in the 
/// dictionary we return it; if not add the current nums element to the dictionary, with the key being its value and the value being the index in nums.
/// Calling the dictionary Add method will sometimes throw an exception since nums values can be repeated. Instead we re-assign it directly using vals[nums[[i]] = i.
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> vals = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            int ct = target - nums[i];
            if (vals.ContainsKey(ct)) {
                return new int[2]{vals[ct], i};
            }
            
            vals[nums[i]] = i;
        }
        
        throw new Exception("no solution");
            
    }
}
