using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class StringQuestionPractice
    {
        public static void Main(string[] args)
        {

        }

        public string reverseWords(string s)
        {
            //Your code here
            String answer = "";
            char[] separator = { '.' };
            String[] str = s.Split(separator);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                answer += "." + str[i];
            }
            return answer.Substring(1);
        }

        String longestCommonPrefix(String[] arr, int N)
        {
            // code here
            if (N == 1)
            {
                return arr[0];
            }
            String ans = prefix(arr[0], arr[1]);
            for (int i = 2; i < N; i++)
            {
                ans = prefix(ans, arr[i]);
            }
            return ans;
        }

        String prefix(String str1, String str2)
        {
            String str = "";
            int len = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < len; i++)
            {
                if (str1[i] != str2[i])
                {
                    break;
                }
                else
                {
                    str += str1[i];
                }
            }

            if (str.Length == 0)
            {
                return "-1";
            }
            else
            {
                return str;
            }
        }
    }
}
