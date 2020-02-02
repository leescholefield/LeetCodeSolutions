// Runtime 76ms -- faster than 96.61%
//
// Given a valid (IPv4) IP address, return a defanged version of that IP address.
// A defanged IP address replaces every period "." with "[.]".
//
public class Solution {
    public string DefangIPaddr(string address) {
        
        for (int i = address.Length - 2; i > 0; i--) {
            if (address[i] == '.') {
                address = address.Substring(0, i) + "[.]" + address.Substring(i+1);
                i--;
            }
        }
        
        return address;
        
    }
}
