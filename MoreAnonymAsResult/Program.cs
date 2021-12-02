using System;

namespace MoreAnonymAsResult
{
    delegate double Powers(double x);
    internal class Program
    {
        static Powers maker(int n)
        {
            Powers meth;
            meth = delegate(double x)
            {
                double s = 1;
                for (int i = 1; i <=n; i++)
                {
                    s *= x;
                }

                return s;
            };
            return meth;
        }
        public static void Main(string[] args)
        {
            Powers sqr = maker(2);
            Powers cube = maker(3);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0,2}:{1,5}{2,5}{3,5}", i, sqr(i),cube(i),maker(4)(i));
            }
        }
    }
}