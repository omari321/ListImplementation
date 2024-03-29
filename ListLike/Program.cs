﻿using System;
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
        }
        static void test1()
        {
            var list=new ListImplementation<int>(1);
            list.Add(5);
            list.Add(8);
            list[0] = 100;
            list[2] = 9;
            list.GetSize();
            list.GetLast();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list[2]);
           
            Console.WriteLine(list.GetLast());
            Console.WriteLine(list.GetSize());
            Console.WriteLine( list.GetFirst()); 
        }
        static void test2()
        {
            var Todo = new ListImplementation<string>();//{ "gaigvidzeba","adgoma","chama","kbilebisGaxexva","mushaoba"}; es vegar gavaketes
            Todo.Add("raime");
            Todo.Add("gagvidzeba");
            Todo.Clear();
            Todo.Add("raime");
            Todo.Add("raime2");
            Todo[0] = "sizmirdan gamosvla";
            Console.WriteLine(Todo[0]);
            Console.WriteLine("-----");
            Todo.PrintAll();
             foreach(var item in Todo)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(Todo.GetFirst());

        }
    }
}
