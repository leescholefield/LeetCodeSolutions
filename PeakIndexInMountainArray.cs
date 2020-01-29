// Given an array that is definitely a mountain, return any i such that A[0] < A[1] < ... 
// A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1].
public class Solution {
    
    public int PeakIndexInMountainArray(int[] A) {
        int low = 1; // cannot be 0 according to test
        int high = A.Length - 2; // cannot be last elem according to test
        
        while (low < high) {
            
            int mid = (low + high) / 2;
            if (A[mid] < A[mid + 1]) {
                low = mid + 1;
            }
            else {
                high = mid;
            }
        }
        
        return low;
    }
}
