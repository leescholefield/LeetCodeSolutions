/// Problem
/// Given an array A of integers, return true if and only if it is a valid mountain array.
/// Recall that A is a mountain array if and only if:
///      A.length >= 3
///      There exists some i with 0 < i < A.length - 1 such that:
///             A[0] < A[1] < ... A[i-1] < A[i]
///             A[i] > A[i+1] > ... > A[A.length - 1]
/// 
/// Solution
/// Walks up the array until we the next value is less than current one. This should be our
/// peak. If this is either the first or last element it is invalid. Then we continue walking 
/// the array but this time making sure the next element is less than the current one.
/// Once we've finished this loop the counter should be equal to the array length-1.
///
/// Runtime: 120 ms (faster than 69.23%)
public class Solution {
    public bool ValidMountainArray(int[] A) {
        if (A.Length < 3)
            return false;
        
        // counter
        int i = 0;
        // walk up until we get first decreasing
        while ( (i+1 < A.Length) && (A[i] < A[i+1])) {
            i++;
        }
        
        // early termination check
        if (i == 0 || i == A.Length -1) {
            return false;
        }
        
        // since we've found a peak every element after this should decrease
        while ( (i+1 < A.Length) && (A[i] > A[i+1])) {
            i++;
        }
        
        // if i != length then we hit an increasing element while walking down the mountain
        return i == A.Length - 1;
    }
}
