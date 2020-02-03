/**
 * Given a binary tree, return the sum of values of its deepest leaves.
 *
 * Uses two recursive algorithms; the first detects the deepest level, the second returns the
 * values at that level. These could probably be combined so you only need to pass through 
 * the tree once.
 */
public class Solution {
    public int DeepestLeavesSum(TreeNode root) {
        
        int maxDepth = GetMaximumDepth(root);
        int sum = GetValuesAtDepth(root, 0, maxDepth);
        return sum;
    }
    
    private int GetMaximumDepth(TreeNode n) {
        
        if (n == null) {
            return 0;
        }
        
        // return + 1 for current node
        return (1 + Math.Max(GetMaximumDepth(n.left), GetMaximumDepth(n.right)));
    }
    
    private int GetValuesAtDepth(TreeNode n, int currentDepth, int targetDepth) {

        if (n == null) {
            return 0;
        }
        
        if (currentDepth + 1 == targetDepth) {
            return n.val;
        }
        
        else {
            int cd = currentDepth + 1;
            return GetValuesAtDepth(n.left, cd, targetDepth) + 
                    GetValuesAtDepth(n.right, cd, targetDepth);
        }
    }
}
