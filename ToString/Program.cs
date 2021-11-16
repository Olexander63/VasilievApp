using System;

namespace ToString
{
    // Клас с переопределением метода ToString();
    class MyClass
    {
        //  Целочисленное поле:
        public int num;
        //  Символьное поле:
        public char symb;
        // Конструктор:
        public MyClass(int n, char s)
        {
            // Присваивание значений полям:
            num = n;
            symb = s;
            // Отображение сообщения о создание обьекта.
            // Неявно вызываеться метод ToString():
            Console.WriteLine("Создан новый обькт\n" +this);
            
        }
        // Переопределение мтода ToString()
        public override String ToString()
        {
            // Локальная текстовая переменная:
            String txt = "Числовое поле: " +num;
            txt += "\nСимвольное поле: " + symb;
            //  Результат метода:
            return txt;
        }
    }
    // Клас с главным методом программы:
    class Program
    {
        // Главный метод:
        public static void Main(string[] args)
        {
           // Создание нового обьекта:
           MyClass obj = new MyClass(100, 'A');
           // Новый значения полей обьекта:
           obj.num = 200;
           obj.symb = 'B';
           Console.WriteLine("Новые значения полей обьекта");
           // Отображение значений полей обьекта.
           // неявно вызывается метод ToString():
           Console.WriteLine(obj);
           // Розбивка текста с описанием оьекта на подстрокию
           // Метод ToSting() вызывается в явном виде:
           String[] str = obj.ToString().Split('\n');
           Console.WriteLine("Явный вызов метода ToString() ");
           // отображение подстрок, содержащих значения полей  обьекта:
           for (int k = 0; k < str.Length; k++)
           {
               Console.WriteLine("[* "+str[k]+" *]");
           }
        }
    }
}