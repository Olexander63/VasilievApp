using System;

namespace StringAndPointer
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            String txt = "Программируем на С#";
            Console.WriteLine(txt);
            fixed (char* p = txt)
            {
                for (int k = 0; p[k]!='\0'; k++)
                {
                    Console.Write("|"+ p[k]);
                    p[k] = (char) ('A' + k);
                }

                Console.WriteLine("|");
            }

            Console.WriteLine(txt);
        }
    }
}