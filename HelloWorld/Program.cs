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

            Console.WriteLine("Overflow");
            Console.WriteLine(int.MaxValue + lungime);
            

            int latime = 6;

            var noteExamen = new Dictionary<string, int>();

            int ariaDreptunghiului = lungime * latime;
            var perimetruDreptunghiului = lungime * 2 + latime * 2;
            
            Console.WriteLine(ariaDreptunghiului);
        }
    }
}
