using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDelegateRest
{
    delegate T MD<T>(T[] arg) where T : struct;
    internal class Program
    {
        static T First<T>(T[] t) where T: struct
        {
            return t[0];
        }
        static T Last<T>(T[] t)
        {
            return t[t.Length - 1];
        }

        static int MaxVal(int[] a)
        {
            int val = a[0];
            for (int k = 0; k < a.Length; k++)
            {
                if (val < a[k]) val = a[k];
            }
            return val;
        }
        static void Main(string[] args)
        {
            MD<int> A = First<int>;
            MD<char> B = Last;
            MD<int> C = MaxVal;
            int x = A(new int[] { 10, 7, 3, 1 });
            char y = B(new char[] { 'A', 'C', 'F' });
            int z = C(new int[] { 1, 7, 2, 5, 11, 9, 3, 6 });
            Console.WriteLine("Значения: {0},{1} и {2}",x,y,z);
        }
    }
}
