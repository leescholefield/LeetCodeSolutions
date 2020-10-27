/* You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

Gotcha: mid = (low + high) / 2 was causing a time limit exceeded error. Reading this blog 
    https://ai.googleblog.com/2006/06/extra-extra-read-all-about-it-nearly.html
It's caused by a bug where low + high causes an overflow. Akways use
    mid = low + (high -low) / 2
From now on.

Runtime: 40 ms (faster than 66%)
*/
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
     
        int low = 0;
        int high = n;
        
        while(low < high) {
            // mid = (low + high) / 2 was causing time limit exceeeded
            int mid = low + (high - low) / 2;
            if (IsBadVersion(mid)) {
                high = mid;
            }
            else {
                low = mid + 1;
            }
        }
        
        return low;
    }
}
