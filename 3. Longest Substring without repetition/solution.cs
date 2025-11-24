/*
These comments are for me, since this took me a bit to understand how
Sliding Window Works. And no, these are not Gpt comments.
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //Using a HashSet for better acess and deletion.
        var unRepeatedSubstring = new HashSet<Char>();
        /*We need two pointers. One for the substring check and another one
        for the beginning of the new substring we'll check whenever we have
        repeated characters. Those are: 
            start: Beginning of the substring without duplicates.
            end: End of the substring w/o repetition, the character being checked in 
                 every iteration.
        */
        int start = 0;
        int max = 0;
        for(int end = 0; end < s.Length; end++) { 
            //Checks if the repeated char is still in the set.
            while(unRepeatedSubstring.Contains(s[end])){
                /*Removes the beginning of the set.
                It will continue until the character is removed.*/
                unRepeatedSubstring.Remove(s[start]);
                /*Advances the substring index
                until we get a clean substring without repetitions.*/
                start++;
            }
            /*Now that the character from the substring is not repeated anymore,
            we add it. */
            unRepeatedSubstring.Add(s[end]);
            /*Checks the current substring chain is bigger than the one previously saved.
             For that we substract the index of the last char checked to the first
             of the substring, adding 1 to count the last char itself.
            */
            max = Math.Max(max, end - start + 1);
        } 
        return max;
    }
}