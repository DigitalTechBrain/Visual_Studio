using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Program
    {
        struct Book
        {
            public int a;
        }

        static void Main(string[] args)
        {
            const int a = 1;
            Console.WriteLine("Constant value is {0}", a);

            Book book1;
            book1.a = 2;

            Console.WriteLine(book1.a);
            Console.ReadLine();
        }
    }


   
    
}

