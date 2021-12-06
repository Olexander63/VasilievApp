using System;

namespace Equation
{
    internal class Program
    {
        static double solve(double A, double B)
        {
            if (A != 0) return B / A;
            string msg;
            if (B == 0) msg = "Решение - любое число";
            else msg = "Решенией нет";
            throw new ArgumentException(msg);
        }
        public static void Main(string[] args)
        {
            double A, B, x;
            Console.WriteLine("Решение уравнения Ax=B");
            try
            {
                Console.Write("Параметр A=");
                A = Double.Parse(Console.ReadLine());
                Console.Write("Параметр B=");
                B = Double.Parse(Console.ReadLine());
                x = solve(A, B);
                Console.WriteLine("Решение x={0}", x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}