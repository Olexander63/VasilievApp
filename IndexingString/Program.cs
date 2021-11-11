using System;

namespace IndexingString
{
    class IndexingStringDemo
    {
        static void Main()
        {
            // Отображение текстового литерала с помощью
            // оператора цикла по коллекции:
            foreach(char s in "Текст"){
                Console.Write(s+" ");
            }
            // Переход к новой строке:
            Console.WriteLine();
            // Отображение текстового литерала с помощью
            // оператора цикла:
            for(int k=0;k<"Текст".Length;k++){
                Console.Write("Текст"[k]+"_");
            }
            // Переход к новой строке:
            Console.WriteLine();
            // Текстовая переменная:
            String A="Изучаем C#";
            // Отображение текстового значения:
            for(int k=0;k<A.Length;k++){
                Console.Write(A[k]);
            }
            // Переход к новой строке:
            Console.WriteLine();
            // Отображение текста в обратном порядке:
            showReversed(A);
            // Проверка значения текстового объекта:
            Console.WriteLine(A);
            // Новый текстовый объект (текст в обратном порядке):
            String B=getReversed(A);
            // Отображение текстового значения:
            Console.WriteLine(B);
        }
        
        // Статический метод для создания текстового объекта,
        // в котором текст записан в обратном порядке:
        static String getReversed(String txt){
            // Локальная текстовая переменная:
            String str="";
            // Формирование текстовой строки:
            foreach(char s in txt){
                // Добавление символа в начало строки:
                str=s+str;
            }
            // Результат метода:
            return str;
        }
        // Статический метод для отображения текста
        // в обратном порядке:
        static void showReversed(String txt){
            // Перебор символов в тексте (в обратном порядке):
            for(int k=txt.Length-1;k>=0;k--){
                // Отображение в консоли символа:
                Console.Write(txt[k]);
            }
            // Переход к новой строке:
            Console.WriteLine();
        }
    }
}