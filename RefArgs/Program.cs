using System;

namespace RefArgs
{
    
     public class Program
    {
        static void alpha(ref int n){
            Console.WriteLine("В методе alpha(). На входе: "+n);
            n++;
            Console.WriteLine("В методе alpha(). На выходе: "+n);
        }
        static void bravo(ref int[] n){
            Console.WriteLine("В методе bravo(). На входе: "+ArrayToText(n));
            for(int k=0;k<n.Length;k++){
                n[k]++;
            }
            Console.WriteLine("В методе bravo(). На выходе: "+ArrayToText(n));
        }
        static void charlie(ref int[] n){
            Console.WriteLine("В методе charlie(). На входе: "+ArrayToText(n));
            int[] m=new int[n.Length];
            for(int k=0;k<n.Length;k++){
                m[k]=n[k]+1;
            }
            n=m;
            Console.WriteLine("В методе charlie(). На выходе: "+ArrayToText(n));
        }
        static string ArrayToText(int[] n){
            string res="["+n[0];
            for(int k=1;k<n.Length;k++){
                res+=","+n[k];
            }
            res+="]";
            return res;
        }
        static void Main(){
            int A=100;
            Console.WriteLine("До вызова метода alpha(): A="+A);
            alpha(ref A);
            Console.WriteLine("После вызова метода alpha: A="+A);
            int[] B={1,3,5};
            Console.WriteLine("До вызова метода bravo(): B="+ArrayToText(B));
            bravo(ref B);
            Console.WriteLine("После вызова метода bravo(): B="+ArrayToText(B));
            int[] C={2,4,6};
            Console.WriteLine("До вызова метода charlie(): C="+ArrayToText(C));
            charlie(ref C);
            Console.WriteLine("После вызова метода charlie(): C="+ArrayToText(C));
        }
    }
}