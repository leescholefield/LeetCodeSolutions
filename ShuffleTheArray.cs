/// Problem
/// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
/// Return the array in the form [x1,y1,x2,y2,...,xn,yn].
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
     
        int[] result = new int[nums.Length];
        
        for (int i = 0; i < n; i++) {
            int index =  i + i;
            result[index] = nums[i];
            result[index+1] = nums[i + n];
        }
        
        return result;
        
    }
}
