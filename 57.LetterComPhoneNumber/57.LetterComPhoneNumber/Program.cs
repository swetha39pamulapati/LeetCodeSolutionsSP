using System;
using System.Collections.Generic;

namespace _57.LetterComPhoneNumber
{
    class Program
    {
        private Dictionary<char, string> getMapWithNumberAndStringMapping()
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('1', "");
            dic.Add('2', "abc");
            dic.Add('3', "def");
            dic.Add('4', "ghi");
            dic.Add('5', "jkl");
            dic.Add('6', "mno");
            dic.Add('7', "pqrs");
            dic.Add('8', "tuv");
            dic.Add('9', "wxyz");
            return dic;
        }
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (digits == null || digits.Length == 0)
                return result;
            Dictionary<char, string> phoneNumberData = getMapWithNumberAndStringMapping();
            letterCombinations(0, digits, "", result, phoneNumberData);
            return result;
        }
        private void letterCombinations(int start, string digits,string data, List<string> result, Dictionary<char, string> phoneNumberdata)
        {
            if(start == digits.Length)
            {
                result.Add(data);
                return;
            }
            char number = digits[start];
            string letters = phoneNumberdata[number];
            for(int i = 0;i< letters.Length; i++)
            {
                letterCombinations(start + 1, digits, data + letters[i], result, phoneNumberdata);
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            IList<string> result = p.LetterCombinations("23");
            Console.WriteLine(result.Count);
        }
    }
}
