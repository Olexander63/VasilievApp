using System;

namespace Pointers
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int n;
            int* p;
            p = &n;
            *p = 123;
            Console.WriteLine("Значение переменной n={0}", n);
            Console.WriteLine("Значение выражения  *p={0}", *p);
            Console.WriteLine("Адрес переменной n: {0}", (uint)p);
            Console.WriteLine();
            byte* q;
            char* s;
            q = (byte*)p;
            s = (char*)p;
            n = 65601;
            Console.WriteLine("Адрес в указателе p: {0}", (uint)p);
            Console.WriteLine("Адрес в указателе q: {0}", (uint)q);
            Console.WriteLine("Адрес в указателе s: {0}", (uint)s);
            Console.WriteLine();
            Console.WriteLine("Значение типа int: {0}", *p);
            Console.WriteLine("Значение типа byte: {0}", *q);
            Console.WriteLine("Значение типа char: \'{0}\'", *s);
            Console.WriteLine("Значение пееменной n={0}", n);
            Console.WriteLine();
            *s = 'F';
            Console.WriteLine("Значение типа int: {0}", *p);
            Console.WriteLine("Значеине типа byte: {0}", *q);
            Console.WriteLine("Значеине типа char: \'{0}\'", *s);
            Console.WriteLine("Значеине переменной  n={0}", n);
            Console.ReadKey();

        }
    }
}