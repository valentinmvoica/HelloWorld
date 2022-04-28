using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti latimea");
            int latime = int.Parse(Console.ReadLine());

            var ariaDreptunghiului = lungime * latime;

            if (ariaDreptunghiului > 100)
            {
                Console.WriteLine("mai mare decat 100");
            }
            else if (ariaDreptunghiului > 50)
            {
                Console.WriteLine("mai mare decat 50");
            }
            else if (ariaDreptunghiului > 30)
            {
                Console.WriteLine("mai mare decat 30");
            }
            else if (ariaDreptunghiului > 20)
            {
                Console.WriteLine("mai mare decat 30");
            }
            else
            {
                Console.WriteLine("e mic boss");
            }


            Console.WriteLine("al doilea if");


            Console.ReadLine();
        }
    }
}
