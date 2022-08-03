using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => _ = Char.IsLetter(c) ? true : false;
        
        public bool CountOfElementsIsEven(string[] vals) => _= (vals.Length%2 == 0) ? true : false;

        public bool IsNumberEven(int number) => _= (number % 2 == 0) ? true : false;

        public bool IsNumberOdd(int num) => _ = (num % 2 == 1) ? true : (num % -2 == -1) ? true : false;
        
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            { 
            var max = numbers.Max();
            var min = numbers.Min();
            return min + max;
            }
        }
    
        public int GetLengthOfShortestString(string str1, string str2) => Math.Min(str1.Length, str2.Length);

        public int Sum(int[] numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                var sum = 0;
                foreach (var number in numbers)
                {
                    if (number % 2 == 0 || number % -2 == 0)
                    {
                        sum += number;
                    }
                }
                return sum;
            }
        }
    
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 == 1 || sum % 2 == -1) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number) => _ = (string.IsNullOrEmpty(number.ToString())) ? 0 : (number <= 0) ? 0 : number / 2;
        
    }
}
