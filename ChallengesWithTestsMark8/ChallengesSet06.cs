
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (words != null)
            {
                switch (ignoreCase)
                {
                    case true:

                        word = word.ToLower();
                        var lc = words.Where(x => x != null).Select(x => x.ToLower()).ToList();
                        containsWord = lc.Contains(word);
                        break;

                    case false:

                        containsWord = words.Where(x => x != null).ToList().Contains(word);
                        break;
                }
            }
            return containsWord;
        }


        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            if (num >= 0) 
            {

                if (num % 2 != 0 && num % 3 != 0)
                { 
                    isPrime = true;
                }
            }
            if (num == 1)
                isPrime = false;

            if (num == 2 || num == 3)
                isPrime = true;
        
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++) 
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex) 
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(var i = 0; i < numbers.Length; i++) 
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++ )
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++; 
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count; 
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List <double>();

            if (elements == null ||  n <= 0 || n > elements.Count)
            {
                return result.ToArray();
            }

            for(var i = n -1; i < elements.Count; i += n) 
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}

