using System;

namespace DelegateAsField
{

    public class Program
    {
        
        delegate void MyDelegate(string txt);

        class MyClass
        {
            public MyDelegate apply;
            public MyClass(MyDelegate md)
            {
                apply = md;
            }
        }

        class Alpha
        {
            private string name;

            public void set(string t)
            {
                name = t;
            }

            public override string ToString()
            {
                return name;
            }
        }

        public static void Main(string[] args)
        {
            Alpha A = new Alpha();
            MyClass obj = new MyClass(A.set);
            obj.apply("Обьект A");
            Console.WriteLine(A);
            Alpha B = new Alpha();
            obj.apply = B.set;
            obj.apply("Обьект B");
            Console.WriteLine(B);
            obj.apply += A.set;
            obj.apply("Обьект X");
            Console.WriteLine(A+" и "+ B);
            obj.apply -= B.set;
            obj.apply("Обьект A");
            Console.WriteLine(A+ " и " + B);
        }
    }
}