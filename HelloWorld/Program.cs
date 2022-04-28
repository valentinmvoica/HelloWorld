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
            

            

            int latime = 6;

            var noteExamen = new Dictionary<string, int>();

            int ariaDreptunghiului = lungime * latime;
            var perimetru = lungime + latime + lungime + latime;
            
            Console.WriteLine(ariaDreptunghiului);
        }
    }
}
