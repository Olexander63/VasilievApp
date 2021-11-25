using System;

namespace InheritAndHiding
{
    class Base
    {
        // Целочисленное поле:
        public int code;
        // Метод для отображения значения поля:
        public void show(){
            Console.WriteLine("Класс Base: "+code);
        }
        // Конструктор с одним аргументом:
        public Base(int n){
            code=n;
        }
    }

    class MyClass:Base{
        // Новое поле замещает одноименное поле,
        // унаследованное из базового класса:
        new public int code;
        // Новый метод замещает одноименный метод,
        // унаследованный из базового класса:
        new public void show(){
            // Вызов версии метода из базового класса:
            base.show();
            // Обращение к полю производного класса:
            Console.WriteLine("Класс MyClass: "+code);
        }
        // Метод для присваивания значения полю, унаследованному
        // из базового класса и замещенного в производном
        // классе:
        public void set(int n){
            // Обращение к полю, унаследованному из базового
            // класса и замещенного в производном классе:
            base.code=n;
        }
        // Конструктор с двумя аргументами:
        public MyClass(int m,int n):base(m){
            // Присваивание значения полю производного класса:
            code=n;
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass(100,200);
            obj.show();
            Console.WriteLine();
            obj.set(300);
            obj.code = 400;
            obj.show();
        }
    }
}