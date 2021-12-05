using System;

namespace PointerToPointer
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int A, B;
            int* p;
            int** q;
            q = &p;
            p = &A;
            **q = 123;
            Console.WriteLine(A);
            *q = &B;
            *p = 321;
            Console.WriteLine(B);
        }
    }
}