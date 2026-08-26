using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numbers = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int currentNumber = nums[i]; //2 
            int requiredNumber = target - currentNumber; //9 - 2 = 7

            if(numbers.ContainsKey(requiredNumber))
            {
                //numbers[requiredNumber] = 1
                //i = 0
                return new int[] {numbers[requiredNumber], i};
            }

            if(!numbers.ContainsKey(currentNumber)){
                numbers[currentNumber] = i;
            }
        }

        return Array.Empty<int>();
    }
}