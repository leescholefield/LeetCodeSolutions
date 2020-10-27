/// Problem
/// Suppose you have a long flowerbed in which some of the plots are planted and some are 
/// not. However, flowers cannot be planted in adjacent plots - they would compete for 
/// water and both would die.
/// Given a flowerbed (represented as an array containing 0 and 1, where 0 means empty and 1
/// means not empty), and a number n, return if n new flowers can be planted in it without
/// violating the no-adjacent-flowers rule.
///
/// Runtime: 104ms (faster than 95.65%)
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
     
        if (n == 0)
            return true;
        
        int toPlant = n;
        for(int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                // check previous
                if (i > 0 && flowerbed[i-1] == 1) {
                    continue;
                }
                // check next
                if (i + 1 < flowerbed.Length && flowerbed[i+1] == 1){
                    continue;
                }
                
                flowerbed[i] = 1;
                toPlant--;
                
                // early termination check
                if (toPlant == 0)
                    return true;
            }
        }
        
        return toPlant == 0;
    }
}
