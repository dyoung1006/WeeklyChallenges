using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    isLower = true;
                }

                if (char.IsUpper(c))
                {
                    isUpper = true;
                }

                if (char.IsNumber(c))
                {
                    isNumber = true;
                }
            }

            if (isNumber == true && isLower == true && isUpper == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            //--if we wanted a true letter
            //foreach (char c in val)
            //{
            //    if (Char.IsLetter(c))
            //    {
            //        return c;
            //    }
            //}
            //return ' ';


            if (val == null)
            {
                return ' ';
            }
            char[] charArray = val.ToArray();
            return charArray[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (val == null)
            {
                return ' ';
            }

            char[] charArray = val.ToCharArray();   
            Array.Reverse(charArray);
            return charArray[0];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null) 
            {   
                return 0;
            }
            int fv = nums[0];
            int sv = nums[nums.Length - 1];

            return sv - fv;
        }

        public int[] GetOddsBelow100()
        {
            List<int>nums = new List<int>();    
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    nums.Add(i);
                }
            }
            return nums.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
