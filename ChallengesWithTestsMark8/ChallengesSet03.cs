using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0 || numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");

            var isValid = hasNumber.IsMatch(password) && hasLowerChar.IsMatch(password) && hasUpperChar.IsMatch(password);
            return isValid;
        }


        public char GetFirstLetterOfString(string val)
        {
            char first = val.FirstOrDefault();
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val.LastOrDefault();
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            return 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var result = from x in Enumerable.Range(0, 100).Where(x => x % 2 != 0)
                         select x;
            return result.ToArray();
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
