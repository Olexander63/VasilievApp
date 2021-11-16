using System;

namespace UsingProgs
{
    // Клас со сойствами
    class MyClass
    {
        // Закрытое целочисленные поля:
        private int num;
        private int min;
        private int max;
        // Коструктор с двумя аргументами:
        public MyClass(int a,int b){
            // Присваивание значения полям:
            min=a;
            max=b;
            // Присваивание значения свойству:
            code=(max+min)/2;
        }
        // Описание целочисленного свойства:
        public int code
        {   
            // Метод вызывается при считывании значения свойства:
            get
            {
                return num;
            }
            
            // Метод вызывается при присваивании значения свойству:
            set
            {
                if (value < min) num = min;
                else if (value > max) num = max;
                else num = value;
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass(1, 9);
            Console.WriteLine("Свойство code:  "+obj.code);
            obj.code = 7;
            Console.WriteLine("Свойство сode: "+obj.code);
            obj.code = 20;
            // Проверка значения свойства:
            Console.WriteLine("Свойство сode: "+obj.code);
            obj.code = -10;
            Console.WriteLine("Свойство сode: "+obj.code);
        }
    }
}