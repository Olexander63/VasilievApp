using System;
using System.Threading;

namespace Lock
{
    class MyClass
    {
        public int state = 0;
    }
internal class Program
{
    static void run(bool type, MyClass obj)
    {
        int val, k = 1;
        Random rnd = new Random();
        while (k<=5)
        {
            val = obj.state;
            Console.WriteLine("{0,4}: прочитано значение {1,2}", Thread.CurrentThread.Name, val);
            Thread.Sleep(rnd.Next(1000,3001));
            if (type) val++;
            else val--;
            Console.WriteLine("{0,4}: присвоено значение {1,2}", Thread.CurrentThread.Name, obj.state);
            k++;
            // lock (obj)
            // {
            //
            // }
        }
    }
    public static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Thread up = new Thread(() => run(true, obj));
        up.Name = "UP";
        Thread down = new Thread(() => run(false, obj));
        down.Name = "DOWN";
        up.Start();
        down.Start();
    }
}
}