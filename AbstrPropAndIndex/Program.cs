using System;

namespace AbstrPropAndIndex
{
    abstract class Base
    {
        public abstract string text
        {
            get;
            set;
        }

        public abstract char this[int k]
        {
            get;
        }

        public abstract int length
        {
            get;
        }
    }

    class Alpha:Base
    {
        private char[] symbs;

        public Alpha(string t) : base()
        {
            text = t;
        }

        public override string text
        {
            get
            {
                return new string(symbs);
            }
            set
            {
                symbs = value.ToCharArray();
            }
        }

        public override int length
        {
            get
            {
                return symbs.Length;
            }
        }

        public override char this[int k]
        {
            get
            {
                return symbs[k];
            }
        }
    }

    class Bravo:Base
    {
        private string txt;

        public Bravo(string t) : base()
        {
            text = t;
        }

        public override string text
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }

        public override int length
        {
            get
            {
                return txt.Length;
            }
        }


        public override char this[int k]
        {
            get
            {
                return txt[k];
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Base obj = new Alpha("Alpha");
            Console.WriteLine(obj.text);
            obj.text = "Base";
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write("|"+ obj[k]);
            }

            Console.WriteLine("|");
            obj = new Bravo("Bravo");
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write("|"+obj[k]);
            }

            Console.WriteLine("|");
            obj.text = "Base";
            Console.WriteLine(obj.text);
        }
    }
}