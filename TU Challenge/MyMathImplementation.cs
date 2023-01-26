using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (age >= 0 && age <= 140)
            {
                if (age >= 18)
                {
                    return true;
                }
                return false;
            }
            throw new ArgumentException();
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
            List<int> list = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }

            return list;
            throw new NotImplementedException();
        }

        public static int Power2(int a)
        {
            return a*a;
            throw new NotImplementedException();
        }

        public static int Power(int a, int b)
        {
            int x = a;
            for (int i = 1; i < b; i++)
            {
                x *= a;
            }
            return x;
            throw new NotImplementedException();
        }

        public static bool IsInOrder(int a, int b)
        {
            /*
            if (a == b)
            {
                return 0;
            }
            return (b - a) / Math.Abs(a - b);
            */
            throw new NotImplementedException();

        }

        public static bool IsListInOrder(List<int> list)
        {
            /*
            if (list.Count < 2)
            {
                return true;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                int result = IsInOrder(list[i], list[i + 1]);
                if (result < 0)
                {
                    return false;
                }
            }
            return true;
            */
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

        public static List<int> Sort(List<int> toSort)
        {
            for (int i = 1; i < toSort.Count; i++)
            {
                for (int j = 0; j < toSort.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    
                    if (toSort[i] < toSort[j] && i > j)
                    {
                        int t = toSort[j];
                        for (int d = i; d > j; d--)
                        {
                            toSort[d] = toSort[d-1];
                        }
                        toSort[j] = t;
                    }
                }
            }
            return toSort;
        }
    }
}
