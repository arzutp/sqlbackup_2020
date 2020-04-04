using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Utility
{
    public static class utility
    {
        public static string encryption(string s) {

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
           
            string reversedS= new string(charArray);

            charArray = reversedS.ToCharArray();
            for(int i=0;i<charArray.Length;i++) //  each (char ch in charArray)
            {
                charArray[i] = Convert.ToChar(Convert.ToInt32(charArray[i]) + 10);
            }


            string resultString = new string(charArray);

            return resultString;
        
        }
        public static string decryption(string s)
        {

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            string reversedS = new string(charArray);

            charArray = reversedS.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) //  each (char ch in charArray)
            {
                charArray[i] = Convert.ToChar(Convert.ToInt32(charArray[i]) - 10);
            }


            string resultString = new string(charArray);

            return resultString;

        }

    }
    public static class StringExtension
    {
        // This is the extension method.
        // The first parameter takes the "this" modifier
        // and specifies the type for which the method is defined.
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string encryption(this String s)
        {

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            string reversedS = new string(charArray);

            charArray = reversedS.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) //  each (char ch in charArray)
            {
                charArray[i] = Convert.ToChar(Convert.ToInt32(charArray[i]) + 10);
            }


            string resultString = new string(charArray);

            return resultString;

        }
        public static string decryption(this String s)
        {

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            string reversedS = new string(charArray);

            charArray = reversedS.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) //  each (char ch in charArray)
            {
                charArray[i] = Convert.ToChar(Convert.ToInt32(charArray[i]) - 10);
            }


            string resultString = new string(charArray);

            return resultString;

        }

    }
}
