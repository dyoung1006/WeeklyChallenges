using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    answer += number;
                }
                else 
                {
                    answer -= number;
                }                
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strArr = {str1, str2, str3, str4 };
            List<int> strLength = new List<int>(); 

            foreach (string str in strArr)
            {
                strLength.Add(str.Length);               
            }

            return strLength.OrderBy(x => x).First();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = {number1, number2, number3, number4 };
           
            return numbers.OrderBy(x => x).First();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                    sideLength1 + sideLength2 > sideLength3 &&
                    sideLength2 + sideLength3 > sideLength1 &&
                    sideLength1 + sideLength3 > sideLength2
                   );
        }

        public bool IsStringANumber(string input)
        {
            //eturn input.All(char.IsNumber);

            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var numberOfObjs = objs.Length;
            var majority = (numberOfObjs / 2) + 1;
            var nullcount = 0;
            foreach(var obj in objs)
            {
                if (obj == null)
                    nullcount++;
            }

            if (nullcount >= majority)
            {
                return true;
            }
            else { return false; }
        }

        public double AverageEvens(int[] numbers) 
        {
            if (numbers == null || numbers.Count() == 0) return 0;

            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            if (evenNumbers.Count() == 0) return 0;

            return evenNumbers.Average();
        }

        public int Factorial(int number)
        {
            int factorial = 1;

            if (number < 0) { throw new ArgumentOutOfRangeException();}

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
