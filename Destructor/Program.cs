using System;

namespace Destructor
{
    
    //Клас с конструктором и деструктором:
    class MyClass
    {
        //Закрытое текстоволе поле
        private string name;
        //Контсруктор:
        public MyClass(string txt)
        {
            //Присваивание значения полю:
            name = txt;
            //Отображение сообщения:
            Console.WriteLine("Создан обьект \"{0}\"",name);
        }
        //Деструктор:
        ~MyClass()
        {
            //Отображение сообщения:
            Console.WriteLine("Удален обьект \'{0}\'",name);
        }
    }
    
    // Главный метод:
    class DestructorDemo
    {   
        // Статический метод:
        static void maker( string txt)
        {
            // Создание анонимного обьекта:
            new MyClass(txt);
        }
        
        // Главный метод:
        public static void Main(string[] args)
        {
            // Создание обьекта:
            MyClass A = new MyClass("Первый");
            
            // Создание анонимного обьекта:
            new MyClass("Второй");
            
            //Новый обьект:
            A = new MyClass("Третий");
            
            //Вызов статического метода:
            maker("Четвертый");
            
            // Новый обьект:
            A = new MyClass("Пятый");
        }
    }
}