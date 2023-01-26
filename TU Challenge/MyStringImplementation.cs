using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            else
            {
                foreach (char c in input)
                {
                    if (c != ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            string r = "";
            int lenghtMix;
            if (a == null || b == null || a == "" || b == "")
            {
                throw new ArgumentException();
            }
            if (a.Length < b.Length)
            {
                lenghtMix = a.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    r += a[i];
                    r += b[i];
                }
                for (int i = lenghtMix; i < b.Length; i++)
                {
                    r += b[i];
                }
                return r;
            }
            if (a.Length > b.Length)
            {
                lenghtMix = b.Length;
                for (int i = 0; i < lenghtMix; i++)
                {
                    r += a[i];
                    r += b[i];
                }
                for (int i = lenghtMix; i < a.Length; i++)
                {
                    r += a[i];
                }
                return r;
            }
            for (int i = 0; i < a.Length; i++)
            {
                r += a[i];
                r += b[i];
            }
            return r;
        }

        public static string ToLowerCase(string a)
        {
            string r = "";
            foreach (char c in a)
            {
                if (c >= 65 && c <= 90 || c >= 182 && c <= 214)
                {
                    r += (char)(c+32);
                }
                else
                {
                    r += (char)(c);
                }
            }
            return r;
        }

        public static string Voyelles(string a)
        {
            string r = "";
            List<int> listV = new List<int>() { 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121 };
            
            foreach (char c in a)
            {
                for (int i = 0; i < listV.Count(); i++)
                {
                    if (c == listV[i])
                    {
                        r += c;
                        listV.Remove((int)c);
                    }
                }
            }
            return ToLowerCase(r);
        }

        public static string Reverse(string a)
        {
            string r = "";

            for (int i = a.Length -1; i >= 0; i--)
            {
                r += a[i];
            }
            return r;
        }

        public static string BazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
                i++;
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                result += input[i];
                result += input[i + input.Length / 2];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            char[] output = input.ToCharArray();
            for (int i = 0; i < output.Length; i++)
            {
                if (string.Compare(ToLowerCase(output[i].ToString()), "a") >= 0 && 
                    string.Compare(ToLowerCase(output[i].ToString()), "z") <= 0)
                {
                    int c = (int)output[i] + offset;
                    if (c > (int)'z')
                    {
                        c -= 26;
                    }
                    output[i] = (char)c;
                }
            }
            return new string(output);
        }
    }
}