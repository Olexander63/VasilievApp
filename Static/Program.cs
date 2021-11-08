using System;

namespace Static
{
    
    //Клас со статическим полем и методом:
    class MyClass
    {
        //  Статическое поле
        public static int code = 100;
        
        // Статический й метод:
        public static void show()
        {
            Console.WriteLine("Статическое поле: " + code);
        }
    }
    class StaticDemo
    {
        public static void Main()
        {
            // Вызов статического метода:
            MyClass.show();
            // Обращение к статическому полю:
            MyClass.code = 200;
            // Вызов статического метода:
            MyClass.show();
        }
    }
}