using System;
using System.Collections;

namespace ArrayListDemo
{
    internal class ArrayListColls
    {
        public static void Main(string[] args)
        {
            int n = 10;
            ArrayList fibs = new ArrayList();
            fibs.Add(1);
            fibs.Add(1);
            for (int k = 2; k <=n ; k++)
            {
                fibs.Add((int) fibs[fibs.Count - 1] + (int) fibs[fibs.Count - 2]);
            }

            foreach (object obj in fibs)
            {
                Console.Write("|"+ obj);
            }

            Console.WriteLine("|");
            fibs.Remove(1);
            fibs.Remove(5);
            fibs.Insert(0,100);
            fibs.Reverse();
            int[] nums = (int[]) fibs.ToArray(typeof(int));
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write("|"+nums[k]);
            }

            Console.WriteLine("|");
        }
    }
}