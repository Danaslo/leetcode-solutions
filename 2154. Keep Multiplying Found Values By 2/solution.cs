public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        foreach(int number in nums)
            numMap[number] = number;
        while(numMap.ContainsKey(original))
            original *=2;
        return original;
    }
}