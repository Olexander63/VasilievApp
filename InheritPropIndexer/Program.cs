using System;

namespace InheritPropIndexer
{
class Alpha{
   // Защищенное целочисленное поле:
   protected int alpha;
   // Закрытый массив:
   private char[] symbs;
   // Конструктор с двумя аргументами:
   public Alpha(int a,string txt){
      // Присваивание значения полю:
      alpha=a;
      // Создание массива на основе текстового аргумента:
      symbs=txt.ToCharArray();
   }
   // Виртуальное свойство:
   public virtual int number{
      // Аксессор для считывания значения:
      get{
         return alpha;
      }
      // Аксессор для присваивания значения:
      set{
         alpha=value;
      }
   }
   // Открытое свойство:
   public int length{
      // Аксессор для считывания значения:
      get{
         return symbs.Length;
      }
   }
   // Символьный индексатор с целочисленным индексом:
   public char this[int k]{
      // Аксессор для считывания значения:
      get{
         return symbs[k];
      }
      // Аксессор для присваивания значения:
      set{
         symbs[k]=value;
      }
   }
   // Виртуальный целочисленный индексатор
   // с символьным индексом:
   public virtual int this[char s]{
      // Аксессор для считывания значения:
      get{
         // Используется индексирование объекта:
         return this[s-'a'];
      }
      // Аксессор для присваивания значения:
      set{
         // Используется индексирование объекта:
         this[s-'a']=(char)value;
      }
   }
   // Переопределение метода ToString():
   public override string ToString(){
      // Текстовая переменная:
      string txt="|";
      // Формируется значение текстовой переменной:
      for(int k=0;k<this.length;k++){
         txt+=this[k]+"|";
      }
      // Результат метода:
      return txt;
   }
}
// Производный класс:
class Bravo:Alpha{
   // Защищенное целочисленное поле:
   protected int bravo;
   // Конструктор с тремя аргументами:
   public Bravo(int a,int b,string txt):base(a,txt){
      // Значение целочисленного поля:
      bravo=b;
   }
   // Переопределение свойства:
   public override int number{
      // Аксессор для считывания значения:
      get{
         return alpha+bravo;
      }
   }
   // Переопределение индексатора с символьным индексом:
   public override int this[char s]{
      // Аксессор для считывания значения:
      get{
         if(s=='a') return alpha;
         else return bravo;
      }
      // Аксессор для присваивания значения:
      set{
         if(s=='a') alpha=value;
         else bravo=value;
      }
   }
}
     class Program
    {
        public static void Main(string[] args)
        {
           // Целочисленная переменная:
           int k;
           // Символьная переменная:
           char s;
           // Создание объекта базового класса:
           Alpha A=new Alpha(100,"ABCD");
           Console.WriteLine("Объект A:");
           // Содержимое символьного массива объекта:
           Console.WriteLine(A);
           // Значение свойства number объекта:
           Console.WriteLine("A.number="+A.number);
           // Присваивание значения свойству number:
           A.number=150;
           // Значение свойства number объекта:
           Console.WriteLine("A.number="+A.number);
           // Индексирование объекта:
           for(k=0,s='a';k<A.length;k++,s++){
              Console.WriteLine("Символ \'{0}\' с кодом {1}",A[k],A[s]);
           }
           A[0]='E';
           A['b']='A'+10;
           // Содержимое символьного массива объекта:
           Console.WriteLine(A);
           // Создание объекта производного класса:
           Bravo B=new Bravo(200,300,"EFGHI");
           Console.WriteLine("Объект B:");
           // Содержимое массива объекта:
           Console.WriteLine(B);
           // Значение свойства number объекта:
           Console.WriteLine("B.number="+B.number);
           // Присваивание значения свойству number объекта:
           B.number=400;
           // Значение свойства number объекта:
           Console.WriteLine("B.number="+B.number);
           // Индексирование объекта:
           B['a']=10;
           B['d']=20;
           Console.WriteLine("B[\'a\']="+B['a']);
           Console.WriteLine("B[\'b\']="+B['b']);
           // Проверка значения свойства number объекта:
           Console.WriteLine("B.number="+B.number);
           // Индексирование объекта:
           for(k=0;k<B.length;k++){
              Console.Write(B[k]+" ");
              B[k]=(char)('a'+k);
           }
           Console.WriteLine();
           // Проверка содержимого массива объекта:
           Console.WriteLine(B);
        }
    }
}