using System;

namespace UsingObjs
{       
    //описание класса:
    class MyClass
    {
        //Целочисленое поле:
        public int number;
        //Символьное поле:
        public char symbol;
        //Метод:
        public void show()
        {
            //Отображение значения целочисленного полея:
            Console.WriteLine("Целочисленое поле: " + number);
            //Отображение значения символьного поля:
            Console.WriteLine("Символьное поле: "+symbol);
        }

    }
    
    //Клас с главным методом:
    class ObjsDemo
    {   
        //Главный метод:
        static void Main()
        {
            //Первый обьект:
            MyClass A = new MyClass();
            //Оюьектная переменная:
            MyClass B;
            //Второй обькт:
            B = new MyClass();
            //Присваивание значений полям первого обьекта:
            A.number = 123;
            A.symbol = 'A';
            //Присваивание значений полям второго обьекта:
            B.number = 321;
            B.symbol = 'B';
            //Вызов методов:
            Console.WriteLine("Первый обьект");
            A.show();
            Console.WriteLine("Второй обьект");
            B.show();
        }
    }
}