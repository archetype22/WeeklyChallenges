using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                    else if (numbers[i] % 2 != 0)
                    {
                        sum -= numbers[i];
                    }
                }
                return sum;
            }
            return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = new int[4] { str1.Length, str2.Length, str3.Length, str4.Length };

            return lengths.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            IList<int> intList = new List<int>() { number1, number2, number3, number4 };
            var result = intList.Min();
            return result;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength2 + sideLength3 <= sideLength1 || sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }

            return true;
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double x);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;
            foreach (var obj in objs) 
            {
                if (obj == null) 
                {
                    count++;
                }
            }
            if (count >= majority) 
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length ==0) 
            {
                return 0;
            }
            var num = numbers.Where(x => x % 2 == 0);

            if (num.Count() == 0) 
            {
                return 0;
            }               
            return num.Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;  
            
            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (int i = number; i > 0; i--) 
            {
                fact *= i;
            }
            return fact;
        }
    }
}
