using System;

namespace MoreMyException
{
    class MyException:Exception
    {
        private string time;
        private string source;

        public MyException(Exception obj) : base("Ошибка класса MyException")
        {
            source = obj.GetType().Name;
            time = DateTime.Now.ToString();
        }

        public override string ToString()
        {
            string txt = Message + "\n";
            txt += "Исходный клас ошибки: " + source + "\n";
            txt += "Дата и время генерирования: " + time;
            return txt;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                try
                {
                    int[] a = {1};
                    a[1] = 2;
                }
                catch (Exception e)
                {
                    MyException me = new MyException(e);
                    throw me;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}