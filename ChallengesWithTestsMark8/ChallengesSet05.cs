﻿
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n) => ((startNumber/n) + 1) * n;
                   
       
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses) 
            {
                if (business.TotalRevenue == 0)
                { 
                    business.Name = "CLOSED"; 
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            bool IsAscendingOrder = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    IsAscendingOrder = false;
                }
            }
            return IsAscendingOrder;            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {         
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1;i < numbers.Length;i++) 
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }                               
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null  || words.Length == 0)
                return "";

            string sentence = string.Empty;
            
            foreach (var word in words)
            {                
              if (word.Trim().Length > 0) 
                {
                    sentence += word.Trim() + " ";       
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null ||  elements.Count == 0)
            {
                return new double[0];
            }
                
            List<double> result = new List<double>();

            for(int i = 1; i <= elements.Count; i++) 
            {
                if (i % 4 == 0 && i / 4 >= 1)                   
                {
                    result.Add(i);
                }
            }   
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
           if (nums == null || nums.Length == 0)
            { 
                return false; 
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
