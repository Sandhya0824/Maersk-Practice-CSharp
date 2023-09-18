using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class StringPractice
    {
        public static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine(str);
        }

        public static void StringFormatMethod()
        {
            //number formats
            Console.WriteLine(String.Format("{0:n}", 657484934));   //thousand separator
            Console.WriteLine(String.Format("{0:c}", 7359234));     //currency
            Console.WriteLine(String.Format("{0:e}", 874098865));   //scientific
            Console.WriteLine(String.Format("{0:f}", 1273981));     //fixed
            Console.WriteLine(String.Format("{0:g}", 6348970231442));   //general

            //custom format
            Console.WriteLine("{0:00.00}", 1.3);    //zero placeholder
            Console.WriteLine("{0:(#).##}", 1.258); //digit placeholder
            Console.WriteLine("{0:(0).000}", 6329814094);    //decimal point
            Console.WriteLine("{0:0,0}", 524327887);     //thousand separator
            Console.WriteLine("{0:0%}", 452);     //percentage 

            //date and time formats
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("{0:D}", dateTime);   //long date
            Console.WriteLine("{0:d}", dateTime);   //short date
            Console.WriteLine("{0:T}", dateTime);   //long time
            Console.WriteLine("{0:t}", dateTime);   //short time
            Console.WriteLine("{0:f}", dateTime);   //long date time
            Console.WriteLine("{0:g}", dateTime);   //short date time
            Console.WriteLine("{0:M}", dateTime);   //short date
            Console.WriteLine("{0:r}", dateTime);   //date time string
            Console.WriteLine("{0:s}", dateTime);   //sortable date/time  
            Console.WriteLine("{0:u}", dateTime);   //universal sortable date
            Console.WriteLine("{0:U}", dateTime);   //universal full date
            Console.WriteLine("{0:Y}", dateTime);   //month year

            //numeric data
            Console.WriteLine(string.Format("Number: {0:N}", 157)); //decimal format
            Console.WriteLine(string.Format("{0:D}  {1,6:D}", 634, 868)); //
            Console.WriteLine(string.Format("{0,10}", 1));  //right padding
            Console.WriteLine(string.Format("{0,-10} {1}", 1, 4523321)); //left padding
            Console.WriteLine(string.Format("Scientific: {0:E}", 157)); //exponent notation
            Console.WriteLine(string.Format("Currency: {0:C}", 157, CultureInfo.CurrentCulture));   //currency    
            Console.WriteLine(string.Format("Percent: {0:P}", 157));    //percent
            Console.WriteLine(string.Format("Hexadecimal: {0:X}", 157));    //hexadecimal
        }


        public static void LastIndexOfMethod()
        {
            String str1 = "Hello! Beautiful Lady Bug";

            char[] c = new char[] { 'a', 'b' };

            Console.WriteLine(str1.LastIndexOf('B'));
            Console.WriteLine(str1.LastIndexOf('b'));
        // ??   Console.WriteLine(str1.LastIndexOf("beautiful", 2,10, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(str1.LastIndexOf('B', 9, 3));
            Console.WriteLine(str1.LastIndexOf('B', 5));
            Console.WriteLine(str1.LastIndexOf("Lady"));
            Console.WriteLine(str1.LastIndexOf("Men"));

            Console.WriteLine(str1.LastIndexOfAny(c));  //first index of any element present in the char array
        }
        public static void ToCharArrrayMethod()
        {
            string str1 = "DanceIndiaDance";
            char[] charArray = str1.ToCharArray();

            foreach (char c in charArray)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            string str2 = "HelloLuffyTheJoyBoy";
            char[] charArray1 = str2.ToCharArray(3, 7);

            foreach (char c in charArray1)
            {
                Console.Write(c);
            }
        }

        public static void StartsWith()
        {
            String str1 = "GeeksForgeeks";

            Console.WriteLine(str1.StartsWith("Geeks"));
            Console.WriteLine(str1.StartsWith("geeks"));
            Console.WriteLine(str1.StartsWith("Geeks", false, CultureInfo.InvariantCulture));   //independent of culture not associated with any region or country always English
            Console.WriteLine(str1.StartsWith("Geeks", StringComparison.CurrentCulture));  //dependent on culture where the application is accessed may be Germany,French
        }

        public static void PaddingMethods()
        {
            string str1 = "Hello Luffy";
            Console.WriteLine(str1.PadLeft(15));
            Console.WriteLine(str1.PadLeft(15, '*'));

            Console.WriteLine(str1.PadRight(15));
            Console.WriteLine(str1.PadRight(15, '*'));
        }

        public static void UpperLowerCasing()
        {
            string str1 = "HelloLady";
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            String str2 = "HELLOLADY";
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str2.ToLower());

            string str3 = "hellolady";
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str3.ToLower());

            string str4 = "hello@Lady";
            Console.WriteLine(str4.ToUpper());
            Console.WriteLine(str4.ToLower());
        }

        public static void RemoveMethod()
        {
            string str1 = "ILoveMyIndia";
            Console.WriteLine(str1.Remove(0));
            Console.WriteLine(str1.Remove(1, 3));
            Console.WriteLine(str1);

            StringBuilder sb = new StringBuilder("helloladyqueen");
            Console.WriteLine(sb.Remove(3, 6));
            Console.WriteLine(sb);
        }

        public static void IndexOfMethod()
        {
            String str1 = "Hello! Beautiful Lady";

            char[] c = new char[] { 'a', 'b' };

            Console.WriteLine(str1.IndexOf('B'));
            Console.WriteLine(str1.IndexOf('b'));
            Console.WriteLine(str1.IndexOf('B', 9));
            Console.WriteLine(str1.IndexOf('B', 5, 8));
            Console.WriteLine(str1.IndexOf("Lady"));
            Console.WriteLine(str1.IndexOf("Men"));

            Console.WriteLine(str1.IndexOfAny(c));  //first index of any element present in the char array
        }

        public static void EndsWith()
        {
            String str1 = "GeeksForgeeks";

            Console.WriteLine(str1.EndsWith("Geeks"));
            Console.WriteLine(str1.EndsWith("geeks"));
            Console.WriteLine(str1.EndsWith("Geeks",false,CultureInfo.InvariantCulture));   //independent of culture not associated with any region or country always English
            Console.WriteLine(str1.EndsWith("Geeks",StringComparison.CurrentCulture));  //dependent on culture where the application is accessed may be Germany,French
        }

        public static void TrimMethod()
        {
            String str1 = "     Hello";
            Console.WriteLine(str1.Trim());

            String str2 = "12312hcbdcsk3121";
            Console.WriteLine(str2.Trim('2', '1', '3'));

            String str3 = "    Geeks123";
            char[] c = { '1', '2', '3' };
            Console.WriteLine(str3.Trim(c));
        }

        public static void JoinMethod()
        {
            String[] str1 = { "Hello", "How", "Are" };
            string str2 = string.Join("", str1);
            Console.WriteLine(str2);

            String[] str3 = { "She", "is", "a", "very", "beautiful", "lady", "from", "Copehegan" };
            string str4 = string.Join(" ", str3, 2, 4);   //index to index+1
            Console.WriteLine(str4);
        }

        public static void ContainsMethod()
        {
            String str = "Geeks for Geeks";
            Console.WriteLine(str.Contains('f'));
            Console.WriteLine(str.Contains("for"));
            Console.WriteLine(str.Contains('F', StringComparison.OrdinalIgnoreCase));
        }

        public static void ReplaceMethod()
        {
            String str = "Hello Ballloon";
            Console.WriteLine(str.Replace('l', 'k'));

            String str1 = "Dance for Dance for";
            Console.WriteLine(str1.Replace("for", "enjoy"));

            Console.WriteLine(str);         //original string not changed it only return a new string
        }

        public static void ComparingStrings()
        {
            String str1 = "Dance India Dance";
            String str2 = "Dance";
            String str3 = "Dance India Dance";
            String str4 = "z";
            String str5 = "dance";

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));
            Console.WriteLine(str2.Equals(str5,StringComparison.OrdinalIgnoreCase));   

            Console.WriteLine(String.Compare(str1, str2));       //str1 is greater than str2
            Console.WriteLine(String.Compare(str1, str3));      //str1 is equal to str3
            Console.WriteLine(String.Compare(str1, str4));      //str1 is less than str4

            Console.WriteLine(str1.CompareTo(str2));       //str1 is greater than str2
            Console.WriteLine(str1.CompareTo(str3));      //str1 is equal to str3
            Console.WriteLine(str1.CompareTo(str4));      //str1 is less than str4
        }

        public static void SubString() 
        {
            String str1 = "HelloHowAreYou";
            Console.WriteLine(str1.Substring(5));
            Console.WriteLine(str1.Substring(5, 3));
        }

        public static void SplitMethod()
        {

            String str = "Da*nce, India, Dance";
            char[] separator = { ',', '*' };
            int count = 2;

            String[] stringSplit = str.Split(separator, count);

            foreach (String s in stringSplit)
            {
                Console.WriteLine(s);
            }
        }

        public static void StringInterpolation()
        {
            string name = "Ram";
            float i = 9.8674232f;
            string msg = $"Welcome {name} {i} {DateTime.Now}";
            Console.WriteLine(msg);
        }

        public static void StringBuilder()
        {
            string str1 = "hello", str2 = "hiiii";
            String.Concat(str1, str2);

            StringBuilder sb1 = new StringBuilder("Wel");
            StringBuilder sb2 = new StringBuilder("come");
            sb1.Append(sb2);

            Console.WriteLine(str1);        //immutable
            Console.WriteLine(sb1);         //mutable

            StringBuilder sb3 = new StringBuilder(str1);        //converting string ---> stringbuilder
            sb3.Append(str2);
            Console.WriteLine(sb3);

            Console.WriteLine(sb1.ToString());                  //converting stringbuilder ---> string
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

            Console.WriteLine(result1 + " " + result2);
            Console.WriteLine(result3 + " " + result4);
        }

        public static void ConcatMethod()
        {
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(String.Concat(str1, str2));

            string[] strArray = new string[3];
            strArray[0] = "How ";
            strArray[1] = "are ";
            strArray[2] = "you ";

            Console.WriteLine(String.Concat(strArray));
        }

        public static void Basics()
        {
            string str1 = "Hello";

            Console.WriteLine(str1.IndexOf("e"));
            Console.WriteLine("{0}", 1);

        }

        public static void ConvertStringToInt()
        {
            string n1 = "100";
            int n2 = Int32.Parse(n1);

            string n3 = "10000000000000000";
            int n4 = 0;
            Int32.TryParse(n3, out n4);         //will give output as 0 instead of throwing exception if the range is out of bound
            Console.WriteLine(n4);
        }
    }
}

//array of characters
//string is an object of System.String class