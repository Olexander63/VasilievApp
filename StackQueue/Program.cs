using System;
using System.Collections;

namespace StackQueue
{
    class stackQueueDemo
    {
        static void show(ICollection s)
        {
            Console.WriteLine("Содержимое коллекции:");
            foreach (object obj in s)
            {
                Console.Write("|" + obj);
            }

            Console.WriteLine("|");
        }
        static void Main()
        {
            Stack mystack = new Stack();
            mystack.Push("Первый");
            mystack.Push("Второй");
            mystack.Push("Третий");
            show(mystack);
            Console.WriteLine("Прочитано :"+ mystack.Peek());
            show(mystack);
            Console.WriteLine("Извлечено:"+ mystack.Pop());
            show(mystack);
            Queue myqueue = new Queue();
            myqueue.Enqueue("Один");
            myqueue.Enqueue("Два");
            myqueue.Enqueue("Три");
            show(myqueue);
            Console.WriteLine("Прочитано : "+ myqueue.Peek());
            show(myqueue);
            Console.WriteLine("Извлечено :"+myqueue.Dequeue());
            show(myqueue);
        }
    }
}