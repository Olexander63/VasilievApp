using System;

namespace Enum
{
    enum Animals
    {
        Cat,
        Dog,
        Fox,
        Wolf,
        Bear
    };

    enum Coins
    {
        One =1,
        Two,
        Five=5,
        Ten= 10,
        Fifty=50
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("В мире животных");
            Animals animal = Animals.Cat;
            Console.WriteLine("animal: {0,-5} или {1}",animal,(int)animal);
            animal = Animals.Dog;
            Console.WriteLine("animal: {0,-5} или {1}",animal,(int)animal);
            animal = (Animals) 2;
            Console.WriteLine("animal: {0,-5} или {1}",animal,(int)animal);
            animal = animal + 1;
            Console.WriteLine("animal: {0,-5} или {1}",animal,(int)animal);
            animal++;
            Console.WriteLine("animal: {0,-5} или {1}",animal,(int)animal);
            Console.WriteLine("В мире финансов");
            Coins coin;
            Array names = System.Enum.GetValues(typeof(Coins));
            for (int k = 0; k < names.Length; k++)
            {
                coin = (Coins) names.GetValue(k);
                Console.WriteLine("coin: {0,-5} или {1}",coin,(int)coin);
            }




        }
    }
}