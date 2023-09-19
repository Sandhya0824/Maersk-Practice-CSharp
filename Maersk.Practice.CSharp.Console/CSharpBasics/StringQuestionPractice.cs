using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    internal class StringQuestionPractice
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine();
        }

        public string reverseWords(string s)
        {
            //Your code here
            string answer = "";
            char[] separator = { '.' };
            string[] str = s.Split(separator);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                answer += "." + str[i];
            }
            return answer.Substring(1);
        }

        string longestCommonPrefix(string[] arr, int N)
        {
            // code here
            if (N == 1)
            {
                return arr[0];
            }
            string ans = prefix(arr[0], arr[1]);
            for (int i = 2; i < N; i++)
            {
                ans = prefix(ans, arr[i]);
            }
            return ans;
        }

        string prefix(string str1, string str2)
        {
            string str = "";
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
