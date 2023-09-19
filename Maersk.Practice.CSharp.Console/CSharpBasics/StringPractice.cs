using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    internal class StringPractice
    {
        public static void Main(string[] args)
        {
            string str = "hello";
            System.Console.WriteLine(str);
        }

        public static void StringFormatMethod()
        {
            //number formats
            System.Console.WriteLine(string.Format("{0:n}", 657484934));   //thousand separator
            System.Console.WriteLine(string.Format("{0:c}", 7359234));     //currency
            System.Console.WriteLine(string.Format("{0:e}", 874098865));   //scientific
            System.Console.WriteLine(string.Format("{0:f}", 1273981));     //fixed
            System.Console.WriteLine(string.Format("{0:g}", 6348970231442));   //general

            //custom format
            System.Console.WriteLine("{0:00.00}", 1.3);    //zero placeholder
            System.Console.WriteLine("{0:(#).##}", 1.258); //digit placeholder
            System.Console.WriteLine("{0:(0).000}", 6329814094);    //decimal point
            System.Console.WriteLine("{0:0,0}", 524327887);     //thousand separator
            System.Console.WriteLine("{0:0%}", 452);     //percentage 

            //date and time formats
            DateTime dateTime = DateTime.Now;
            System.Console.WriteLine("{0:D}", dateTime);   //long date
            System.Console.WriteLine("{0:d}", dateTime);   //short date
            System.Console.WriteLine("{0:T}", dateTime);   //long time
            System.Console.WriteLine("{0:t}", dateTime);   //short time
            System.Console.WriteLine("{0:f}", dateTime);   //long date time
            System.Console.WriteLine("{0:g}", dateTime);   //short date time
            System.Console.WriteLine("{0:M}", dateTime);   //short date
            System.Console.WriteLine("{0:r}", dateTime);   //date time string
            System.Console.WriteLine("{0:s}", dateTime);   //sortable date/time  
            System.Console.WriteLine("{0:u}", dateTime);   //universal sortable date
            System.Console.WriteLine("{0:U}", dateTime);   //universal full date
            System.Console.WriteLine("{0:Y}", dateTime);   //month year

            //numeric data
            System.Console.WriteLine(string.Format("Number: {0:N}", 157)); //decimal format
            System.Console.WriteLine(string.Format("{0:D}  {1,6:D}", 634, 868)); //
            System.Console.WriteLine(string.Format("{0,10}", 1));  //right padding
            System.Console.WriteLine(string.Format("{0,-10} {1}", 1, 4523321)); //left padding
            System.Console.WriteLine(string.Format("Scientific: {0:E}", 157)); //exponent notation
            System.Console.WriteLine(string.Format("Currency: {0:C}", 157, CultureInfo.CurrentCulture));   //currency    
            System.Console.WriteLine(string.Format("Percent: {0:P}", 157));    //percent
            System.Console.WriteLine(string.Format("Hexadecimal: {0:X}", 157));    //hexadecimal
        }


        public static void LastIndexOfMethod()
        {
            string str1 = "Hello! Beautiful Lady Bug";

            char[] c = new char[] { 'a', 'b' };

            System.Console.WriteLine(str1.LastIndexOf('B'));
            System.Console.WriteLine(str1.LastIndexOf('b'));
            // ??   Console.WriteLine(str1.LastIndexOf("beautiful", 2,10, StringComparison.CurrentCultureIgnoreCase));
            System.Console.WriteLine(str1.LastIndexOf('B', 9, 3));
            System.Console.WriteLine(str1.LastIndexOf('B', 5));
            System.Console.WriteLine(str1.LastIndexOf("Lady"));
            System.Console.WriteLine(str1.LastIndexOf("Men"));

            System.Console.WriteLine(str1.LastIndexOfAny(c));  //first index of any element present in the char array
        }
        public static void ToCharArrrayMethod()
        {
            string str1 = "DanceIndiaDance";
            char[] charArray = str1.ToCharArray();

            foreach (char c in charArray)
            {
                System.Console.Write(c);
            }
            System.Console.WriteLine();

            string str2 = "HelloLuffyTheJoyBoy";
            char[] charArray1 = str2.ToCharArray(3, 7);

            foreach (char c in charArray1)
            {
                System.Console.Write(c);
            }
        }

        public static void StartsWith()
        {
            string str1 = "GeeksForgeeks";

            System.Console.WriteLine(str1.StartsWith("Geeks"));
            System.Console.WriteLine(str1.StartsWith("geeks"));
            System.Console.WriteLine(str1.StartsWith("Geeks", false, CultureInfo.InvariantCulture));   //independent of culture not associated with any region or country always English
            System.Console.WriteLine(str1.StartsWith("Geeks", StringComparison.CurrentCulture));  //dependent on culture where the application is accessed may be Germany,French
        }

        public static void PaddingMethods()
        {
            string str1 = "Hello Luffy";
            System.Console.WriteLine(str1.PadLeft(15));
            System.Console.WriteLine(str1.PadLeft(15, '*'));

            System.Console.WriteLine(str1.PadRight(15));
            System.Console.WriteLine(str1.PadRight(15, '*'));
        }

        public static void UpperLowerCasing()
        {
            string str1 = "HelloLady";
            System.Console.WriteLine(str1.ToUpper());
            System.Console.WriteLine(str1.ToLower());

            string str2 = "HELLOLADY";
            System.Console.WriteLine(str2.ToUpper());
            System.Console.WriteLine(str2.ToLower());

            string str3 = "hellolady";
            System.Console.WriteLine(str3.ToUpper());
            System.Console.WriteLine(str3.ToLower());

            string str4 = "hello@Lady";
            System.Console.WriteLine(str4.ToUpper());
            System.Console.WriteLine(str4.ToLower());
        }

        public static void RemoveMethod()
        {
            string str1 = "ILoveMyIndia";
            System.Console.WriteLine(str1.Remove(0));
            System.Console.WriteLine(str1.Remove(1, 3));
            System.Console.WriteLine(str1);

            StringBuilder sb = new StringBuilder("helloladyqueen");
            System.Console.WriteLine(sb.Remove(3, 6));
            System.Console.WriteLine(sb);
        }

        public static void IndexOfMethod()
        {
            string str1 = "Hello! Beautiful Lady";

            char[] c = new char[] { 'a', 'b' };

            System.Console.WriteLine(str1.IndexOf('B'));
            System.Console.WriteLine(str1.IndexOf('b'));
            System.Console.WriteLine(str1.IndexOf('B', 9));
            System.Console.WriteLine(str1.IndexOf('B', 5, 8));
            System.Console.WriteLine(str1.IndexOf("Lady"));
            System.Console.WriteLine(str1.IndexOf("Men"));

            System.Console.WriteLine(str1.IndexOfAny(c));  //first index of any element present in the char array
        }

        public static void EndsWith()
        {
            string str1 = "GeeksForgeeks";

            System.Console.WriteLine(str1.EndsWith("Geeks"));
            System.Console.WriteLine(str1.EndsWith("geeks"));
            System.Console.WriteLine(str1.EndsWith("Geeks", false, CultureInfo.InvariantCulture));   //independent of culture not associated with any region or country always English
            System.Console.WriteLine(str1.EndsWith("Geeks", StringComparison.CurrentCulture));  //dependent on culture where the application is accessed may be Germany,French
        }

        public static void TrimMethod()
        {
            string str1 = "     Hello";
            System.Console.WriteLine(str1.Trim());

            string str2 = "12312hcbdcsk3121";
            System.Console.WriteLine(str2.Trim('2', '1', '3'));

            string str3 = "    Geeks123";
            char[] c = { '1', '2', '3' };
            System.Console.WriteLine(str3.Trim(c));
        }

        public static void JoinMethod()
        {
            string[] str1 = { "Hello", "How", "Are" };
            string str2 = string.Join("", str1);
            System.Console.WriteLine(str2);

            string[] str3 = { "She", "is", "a", "very", "beautiful", "lady", "from", "Copehegan" };
            string str4 = string.Join(" ", str3, 2, 4);   //index to index+1
            System.Console.WriteLine(str4);
        }

        public static void ContainsMethod()
        {
            string str = "Geeks for Geeks";
            System.Console.WriteLine(str.Contains('f'));
            System.Console.WriteLine(str.Contains("for"));
            System.Console.WriteLine(str.Contains('F', StringComparison.OrdinalIgnoreCase));
        }

        public static void ReplaceMethod()
        {
            string str = "Hello Ballloon";
            System.Console.WriteLine(str.Replace('l', 'k'));

            string str1 = "Dance for Dance for";
            System.Console.WriteLine(str1.Replace("for", "enjoy"));

            System.Console.WriteLine(str);         //original string not changed it only return a new string
        }

        public static void ComparingStrings()
        {
            string str1 = "Dance India Dance";
            string str2 = "Dance";
            string str3 = "Dance India Dance";
            string str4 = "z";
            string str5 = "dance";

            System.Console.WriteLine(str1.Equals(str2));
            System.Console.WriteLine(str1.Equals(str3));
            System.Console.WriteLine(str2.Equals(str5, StringComparison.OrdinalIgnoreCase));

            System.Console.WriteLine(string.Compare(str1, str2));       //str1 is greater than str2
            System.Console.WriteLine(string.Compare(str1, str3));      //str1 is equal to str3
            System.Console.WriteLine(string.Compare(str1, str4));      //str1 is less than str4

            System.Console.WriteLine(str1.CompareTo(str2));       //str1 is greater than str2
            System.Console.WriteLine(str1.CompareTo(str3));      //str1 is equal to str3
            System.Console.WriteLine(str1.CompareTo(str4));      //str1 is less than str4
        }

        public static void SubString()
        {
            string str1 = "HelloHowAreYou";
            System.Console.WriteLine(str1.Substring(5));
            System.Console.WriteLine(str1.Substring(5, 3));
        }

        public static void SplitMethod()
        {

            string str = "Da*nce, India, Dance";
            char[] separator = { ',', '*' };
            int count = 2;

            string[] stringSplit = str.Split(separator, count);

            foreach (string s in stringSplit)
            {
                System.Console.WriteLine(s);
            }
        }

        public static void StringInterpolation()
        {
            string name = "Ram";
            float i = 9.8674232f;
            string msg = $"Welcome {name} {i} {DateTime.Now}";
            System.Console.WriteLine(msg);
        }

        public static void StringBuilder()
        {
            string str1 = "hello", str2 = "hiiii";
            string.Concat(str1, str2);

            StringBuilder sb1 = new StringBuilder("Wel");
            StringBuilder sb2 = new StringBuilder("come");
            sb1.Append(sb2);

            System.Console.WriteLine(str1);        //immutable
            System.Console.WriteLine(sb1);         //mutable

            StringBuilder sb3 = new StringBuilder(str1);        //converting string ---> stringbuilder
            sb3.Append(str2);
            System.Console.WriteLine(sb3);

            System.Console.WriteLine(sb1.ToString());                  //converting stringbuilder ---> string
        }

        public static void StringOperators()
        {
            string str1 = "school";
            string str2 = "School";
            string str3 = "SCHOOL";

            bool result1 = str1 == str2;
            bool result2 = str1 == str3;

            bool result3 = str1 != str2;
            bool result4 = str1 != str3;

            System.Console.WriteLine(result1 + " " + result2);
            System.Console.WriteLine(result3 + " " + result4);
        }

        public static void ConcatMethod()
        {
            string str1 = "Hello";
            string str2 = "World";
            System.Console.WriteLine(string.Concat(str1, str2));

            string[] strArray = new string[3];
            strArray[0] = "How ";
            strArray[1] = "are ";
            strArray[2] = "you ";

            System.Console.WriteLine(string.Concat(strArray));
        }

        public static void Basics()
        {
            string str1 = "Hello";

            System.Console.WriteLine(str1.IndexOf("e"));
            System.Console.WriteLine("{0}", 1);

        }

        public static void ConvertStringToInt()
        {
            string n1 = "100";
            int n2 = int.Parse(n1);

            string n3 = "10000000000000000";
            int n4 = 0;
            int.TryParse(n3, out n4);         //will give output as 0 instead of throwing exception if the range is out of bound
            System. Console.WriteLine(n4);
        }
    }
}

//array of characters
//string is an object of System.String class