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
            if (a == string.Empty || b == string.Empty || a == null || b == null)
            {
                throw new ArgumentException();
            }

            string r = "";

            int minLength = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLength; i++)
            {
                r += a[i];
                r += b[i];
            }

            if (a.Length > minLength)
            {
                r += a.Substring(minLength);
            }
            else if (b.Length > minLength)
            {
                r += b.Substring(minLength);
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

            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
