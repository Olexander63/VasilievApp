using System;
namespace OverloadingCompareOperators
{      
    // Клас с перезрузкой операторов сравнения:
    class MyClass
    {
        // Символьное поле
        public char symb;
        // Коснтруктор с одинм аргументом:
        public MyClass(char s)
        {
            // Присваивание значения полю:
            symb = s;
        }
        // Перегрузка оператора "меньше или равно":
        public static bool operator<=(MyClass a,MyClass b){
            if(a.symb<=b.symb) return true;
            else return false;
        }
        // Перегрузка оператора "больше или равно":
        public static bool operator>=(MyClass a,MyClass b){
            if(a.symb>=b.symb) return true;
            else return false;
        }
        
        
    }
     class Program
    {
        public static void Main()
        {
            // Создание объектов:
            MyClass A=new MyClass('A');
            MyClass B=new MyClass('B');
            MyClass C=new MyClass('A');
            // Использование операторов сравнения:
            Console.WriteLine("A<=B дает {0}",A<=B);
            Console.WriteLine("A>=B дает {0}",A>=B);
            Console.WriteLine("A<=C дает {0}",A<=C);
            Console.WriteLine("A>=C дает {0}",A>=C);
        }
    }
}