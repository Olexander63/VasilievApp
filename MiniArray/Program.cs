using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniArray
{
    class Program
    {
        unsafe static  void Main()
        {
            double miniarray;
            int m = sizeof(double) / sizeof(byte);
            void* pnt;
            pnt = &miniarray;
            byte* p;
            p=(byte*)pnt;
            for (int k = 0; k < m; k++)
            {
                p[k] = (byte)(k + 1);
                Console.Write("|"+ p[k]);
            }
            Console.WriteLine("|");

            p = (byte*)pnt + m - 1;
            for (int k = 0; k < m; k++)
            {
                Console.Write("|"+p[-k]);
            }
            Console.WriteLine("|");

            int n = sizeof(double) / sizeof(char);
            char* q;
            q = (char*)pnt;
            for (int k = 0; k <n;  k++)

            {
                q[k] = (char)('A' + k);
                Console.Write("|" + p[k]);
            }
            Console.WriteLine("|");


            q = (char*)pnt + n - 1;
            for (int k = 0; k < n; k++)
            {
                Console.Write("|" + p[-k]);
            }
            Console.WriteLine("|");

        }
    }
}
