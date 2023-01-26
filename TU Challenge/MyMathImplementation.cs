using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a+ b;
            throw new NotImplementedException();
        }

        public static bool IsMajeur(int age)
        {
            if (age > 17)
            {
                return true;
                throw new NotImplementedException();
            }
            else
            {
                return false;
                throw new NotImplementedException();
            }
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
                throw new NotImplementedException();
            }
            else
            {
                return false;
                throw new NotImplementedException();
            }
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
                throw new NotImplementedException();
            }
            else
            {
                return false;
                throw new NotImplementedException();
            }
        }

        public static bool IsPrimary(int a)
        {
            int b = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    b++;
                }
            }
            if (b == 2)
            {
                return true;
                throw new NotImplementedException();
            }
            else
            {
                return false;
                throw new NotImplementedException();
            }
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 1; i <= a; i = i + 2)
            {
                if (DetermineIsPrime(i) == true && i > 1)
                {
                    primes.Add(i);
                }
            }
            return primes;
            throw new NotImplementedException();
        }
        static bool DetermineIsPrime(int num)
        {
            int y;
            List<int> divisors = new List<int>();
            double x = Math.Sqrt(num);
            y = (int)Math.Ceiling(x);
            if (num == 3 || num == 2)
            {
                return true;
            }
            for (int counter = 1; counter <= y + 1; counter++)
            {
                if (num % counter == 0)
                {
                    divisors.Add(counter);
                    if (divisors.Count > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int Power2(int a)
        {
            return a*a;
            throw new NotImplementedException();
        }

        public static int Power(int a, int b)
        {
            for (int c = 0; c < b; c++)
            {
                a *= a;
            }
            return a;
            throw new NotImplementedException();
        }

        public static bool IsInOrder(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static bool IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static object Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }
    }
}
