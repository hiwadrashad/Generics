using System;

namespace Generics
{
    public class Program<T>
    {
        public T textvalue { get; set; }
        static void Main(string[] args)
        {
            genericclass<string> item = new genericclass<string>();

            item.textvalue = "test this";

            Console.WriteLine(item.returnvalue());
        }
    }

    public class genericclass<T>
    {
    public T textvalue { get; set; }

        public T returnvalue()
        {
            return textvalue;
        }
    }
}
