/// Problem
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
///    Open brackets must be closed by the same type of brackets.
///    Open brackets must be closed in the correct order.
///
/// Solution
/// This uses a simple stack to keep track of the last opening char. If we encounter a closing char and the last char in the stack (or the stack is empty) is not its opposite 
/// then we return false. If we get to the end and the stack is not empty then a tag has not been closed -- return false.
/// Runtime : 76 ms 
public class Solution {
    public bool IsValid(string s) {
        // maintains a list of currently 'open' chars
        Stack<char> openerStack = new Stack<char>();
        
        // could have these in a dictionary but actually takes more time in the test suite
        char[] openers = new char[]{'(', '{', '['};
        char[] closers = new char[]{')', '}', ']'};
        foreach(char c in s) {
            // check if the last char in openerStack is the closers opposite
            if (closers.Contains(c)) {
                if (openerStack.Count == 0) {
                    return false;
                }
                
                int index = Array.IndexOf(closers, c);
                if (openers[index] != openerStack.Pop())
                    return false;
            }
            
            // in a real program we'd want to check whether its an opener here
            // to increase time we're relying on the input being valid
            else {
                openerStack.Push(c);
            }
        }
        
        return openerStack.Count == 0;
    }
}
