using System;
using System.Collections.Generic;

namespace _58._GeneralizedAbbreviation
{
    class Program
    {
        public List<string> generateAbbreviations(string word)
        {
            List<string> result = new List<string>();
            generateAbbreviationHelper("", word, result,0,0);
            return result;
        }
        public void generateAbbreviationHelper(string data,string word, List<string>result,int count, int position)
        {

            //       Wor (: means No, ? yes) (for No, we will increase count, for yes count is 0)
            //      :/  \?
         //(Word|.|1)      (Word|W|0) (for O)
        //    :/    \?              :/  \?
     //(Word|.|2)   (Word|1O|0)  (Word|W|1)    (Word|WO|0)
    //    :/ \?             :/  \?      :/  \?     :/ \?
    //(Word|.|3) (|2r|0) (1O|1)(1Or|0) (|W|2)(|W1R|0) (WO|1) (WOR|0)
    // Result= [3,2r,1O1,1OR,W2,W1R,WO1,WOR]

            //Base condition to exit. if each letter is traversed i.e.. position = 4 then it is equal to
            //WordLength and now check for count, if count is 0 simply add the result(w1rd) or add count also to it(w3);

            if(position == word.Length)
            {
                if(count == 0)
                {
                    result.Add(data);
                
                }
                else
                {
                    data += count;
                    result.Add(data);
                }
                return;
            }
            //in word,(for every character yes or no decision to add the character) 1st the count is zero, so else block( generateAbbreviationHelper( data + word[position], word, result, 0, position + 1);) executes.
            //generatemethod calls till postion == word.Length; Once it returns from the loop it checks for No condition that is generateAbbreviationHelper( data , word, result, count+1, position + 1);
            //Now count becomes 1 and at each step yes or no will be there, so when count is 1 and yes condition is there then  generateAbbreviationHelper(data+count+ word[position], word, result,0,position+1);executes.
            // When decision is yes, we simply and count is 0, we dont add anything to data or we add count also(w1rd).
            //When decision is No, then count increments or count is 0 and position keeps incrementing.
            
            //Yes condition with count as we dont add 0 to the data
            //we will eliminate count when count==0;
            if (count > 0)
                generateAbbreviationHelper(data+count+ word[position], word, result,0,position+1);
        else
                generateAbbreviationHelper( data + word[position], word, result, 0, position + 1);
            
            //No Condition
            generateAbbreviationHelper( data , word, result, count+1, position + 1);
        }
            static void Main(string[] args)
        {
            Program p = new Program();
            List < string> result = p.generateAbbreviations("wor");
            Console.WriteLine(result.Count);
        }
    }
}
