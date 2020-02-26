using Bran.Implementations;
using System;
using System.Linq;

namespace Bran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= Hello Bran! =======================\n");

            Console.Write("Choose an option: ");

            var methodsSearch = new SearchAlgorithms().GetType().GetMethods().ToList();

            methodsSearch.ForEach(method => Console.WriteLine($"{methodsSearch.IndexOf(method)} - {method.Name}"));

            Console.ReadKey();
        }
    }
}
