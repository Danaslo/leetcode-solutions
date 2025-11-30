public class Solution {
    public int MajorityElement(int[] nums) {
        int max = 0;
        int maxNumber = 0;
        HashSet<int> set = new HashSet<int>(nums);
        foreach(int number in set){
            /*Lambda: X means every item on the list, checking if its
              the same as number, adding 1 to rep if that's the case.
            */
            int rep = nums.Count(x => x == number);
            if(rep > max){
                max = rep;
                maxNumber = number;
            }
                
        }
        return maxNumber;
    }
}