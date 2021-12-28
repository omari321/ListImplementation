using System;
using System.Collections.Generic;

namespace ListLike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test1();
            Console.WriteLine("----------");
            test2();
            Console.WriteLine("1");
        }
        static void test1()
        {
            var list=new ListImplementation<int>(1);
            list.Add(5);
            list.Add(8);
            list[2] = 9;
            Console.WriteLine(list[2]);
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.GetLast());
            Console.WriteLine(list.GetSize());
            Console.WriteLine( list.GetFirst()); 
            Console.ReadKey();
        }
        static void test2()
        {
            var Todo = new ListImplementation<string>() { "gaigvidzeba","adgoma","chama","kbilebisGaxexva","mushaoba"};
            Todo.PrintAll();
            Todo[0] = "sizmirdan gamosvla";
            Console.WriteLine(Todo[0]);
            Console.WriteLine("-----");
            foreach(var i in Todo)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(Todo.GetFirst());

        }
    }
}
