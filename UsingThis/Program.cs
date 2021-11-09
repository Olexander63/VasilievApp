using System;

namespace UsingThis
{
    class MyClass
    {
        // Закрытое целочисленое поле:
        private int code;
        // Открытый метод:
        public int get()
        {
            // Использовано ключовое слово this:
            return this.code;
        }
        
        // Открытый метод:
        public void set(int code)
        {
            // Испольовано ключевое слово this:
            this.code = code;
        }
        // Конструктор:
        public MyClass(int code)
        {
            this.code = code;
            // Использование ключевое слово this:
            Console.WriteLine("Создан обьект: " + this.get());
        }
    }
        //Клас с главным методом:
        
    class usingThis
    {   
        //Главный метод:
        
        public static void Main(string[] args)
        {
            //Создание обьекта:
            MyClass obj = new MyClass(100);
            // Присвание значения полю:
            obj.set(200);
            // Проверка значения поля:
            Console.WriteLine("Новое значение: " + obj.get());

        }
    }
}