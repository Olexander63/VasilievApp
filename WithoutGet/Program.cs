using System;

namespace WithoutGet
{

    class MyClass
    {
        private string code;

        public MyClass(uint n){
            // Присваивание значения свойству:
            number=n;
        }

        public override string ToString()
        {
            return code;
        }

        public uint number
        {
            set
            {
                // Локальная переменная:
                uint num=value;
                // Начальное значение текстового поля:
                code="";
                // Вычисление битов числа:
                do{
                    // Значение последнего (младшего) бита
                    // дописывается слева к тексту:
                    code=(num%2)+code;
                    // Сдвиг кода числа на одну позицию вправо:
                    num>>=1;
                }while(num!=0);
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            Console.WriteLine("Бинарный код числа 5:\t"+obj);
            obj.number = 45;
            Console.WriteLine("Бинарный код числа 45:\t"+obj);
        }
    }
}