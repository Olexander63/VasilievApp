using System;

namespace HidingAndOverriding
{
    class Alpha
    {
        public void hello()
        {
            Console.WriteLine("Метод hello() из класса Alpha");
        }

        public virtual void hi()
        {
            Console.WriteLine("Метод hi() из класса Alpha");
        }

        public void show()
        {
            hello();
            hi();
            Console.WriteLine();
        }
    }

    class Bravo: Alpha
        {
            new public void hello()
            {
                Console.WriteLine("Метод hello() из класса Bravo");
            }
        }
    
        internal class Program
        {
            public static void Main(string[] args)
            {
                // Создание объекта базового класса:
                Alpha A=new Alpha();
                Console.WriteLine("Выполнение команды A.show():");
                // Вызов метода:
                A.show();
                // Создание объекта производного класса:
                Bravo B=new Bravo();
                Console.WriteLine("Выполнение команды B.hello():");
                // Вызов замещающего метода из производного класса:
                B.hello();
                Console.WriteLine("Выполнение команды B.hi():");
                // Вызов переопределенного метода:
                B.hi();
                Console.WriteLine("Выполнение команды B.show():");
                // Вызов унаследованного метода:
                B.show();
                Console.WriteLine("После выполнения команды A=B");
                // Объектной переменной базового класса присваивается
                // ссылка на объект производного класса:
                A=B;
                Console.WriteLine("Выполнение команды A.hello():");
                // Вызов замещаемого метода:
                A.hello();
                Console.WriteLine("Выполнение команды A.hi():");
                // Вызов переопределенного метода:
                A.hi();
                Console.WriteLine("Выполнение команды A.show():");
                // Вызов унаследованного метода:
                A.show();
            }
        }
}