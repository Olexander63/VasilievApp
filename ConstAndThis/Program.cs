using System;

namespace ConstAndThis
{   
    // Клас с перегрузкой конструкторов:
    class MyClass
    {
        //Целочисленнные поля:
        public int alpha;
        public int bravo;
        // Конструктор с одним аргументом:
        public MyClass(int a)
        {
            // Сообщение в консольном окне:
            Console.WriteLine("Конструктор с одим аргументом");
            // Значения полей:
            alpha = a;
            bravo = alpha;
            // Отображение значенияполей:
            Console.WriteLine("Оба поля равны" +alpha);
        }
            
        // Конструктор с жвумя аргументами:
        
        public MyClass(int a, int b) : this(a)
        {
            // Сообщение в консольном окне:
            Console.WriteLine("Конструктор с двумя аргументами ");
             //  Значение второго поля:
             bravo = b;
             // Отображение значений полей:
             Console.WriteLine("Поля" +alpha+" и " + bravo);
        }
        
        // Конструктор без аргументов:
        public MyClass() : this(400, 500)
        {
            // Сообщение в консольном окне:
            Console.WriteLine(" Конструктор без аргументов");
            // отображение значений полей:
            Console.WriteLine("Значения "+alpha+" и "+bravo);
        }
    }
    // Клас с главгым методлм:
    
    class ConstrAndThis
    {   // Главный метод:
        public static void Main()
        {
             // Вызовв конструктора с одним аргументом:
             MyClass A = new MyClass(100);
             Console.WriteLine();
             // Вызов конструктора с двумя аргументами:
             MyClass B = new MyClass(200, 300);
             Console.WriteLine();
             // Вызов конструктора без аргументов:
             MyClass C = new MyClass();

        }
    }
}