using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.
namespace Zadatak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz;
            Console.WriteLine("Upišite niz znakova: ");
            niz = Console.ReadLine();
            Console.WriteLine(niz.Replace(" ", "_"));
            Console.ReadKey();
}
}
}
