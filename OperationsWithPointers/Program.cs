using System;

namespace OperationsWithPointers
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double val;
            int k = 1;
            double* start, end;
            start = &val;
            end = start + 1;
            Console.WriteLine("Адрес start\t{0}",(uint)start);
            Console.WriteLine("Адрес end\t{0}",(uint)end);
            Console.WriteLine("Разность адресов (0,6)",(uint)end-(uint)start);
            Console.WriteLine("Разность double - указателей\t{0}",end-start);
            Console.WriteLine("Разность int-указателей \t{0}",(int*)end-(int*)start);
            Console.WriteLine("Разность char-указателей \t{0}",(char*)end-(char*)start);
            Console.WriteLine("Разность byte-указателей \t{0}",(byte*)end-(byte*)start);
            byte* p = (byte*) start;
            char* q = (char*) start;
            int* r = (int*) start;
            Console.WriteLine("Тип byte: ");
            Console.WriteLine("Адрес\tЗначение");
            while (p<end)
            {
                *p=(byte)k;
                Console.WriteLine("{0}\t{1}",(uint)p,*p);
                p++;
                k += 2;
            }
            Console.WriteLine("Типа char:");
            Console.WriteLine("Адрес\tЗначение");
            for (k = 0; q+k < end; k++)
            {
                *(q + k) = (char) ('A' + 2 * k);
                Console.WriteLine("{0}\t{1}",(uint)(q+k),*(q+k));
            }

            Console.WriteLine("Тип int: ");
            Console.WriteLine("Адрес \tЗначение");
            for ( k = 0; q+k < end; k++)
            {
                *(q + k) = (char) ('A' + 2 * k);
                Console.WriteLine("{0}\t{1}",(uint)(q+k),*(q+k));
                Console.WriteLine("Тип int:");
                Console.WriteLine("Адрес\tЗначениме");
                for ( k = 0; &r[k] < end; k++)
                {
                    r[k] = 5 * (k + 1);
                    Console.WriteLine("{0}\t{1}",(uint)&r[k],r[k]);
                }
            }
        }
    }
}