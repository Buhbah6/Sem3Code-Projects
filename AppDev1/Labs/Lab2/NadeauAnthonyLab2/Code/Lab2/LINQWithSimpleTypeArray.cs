using System;
using System.Linq;
    
namespace Lab2 { 
    class LINQWithSimpleTypeArray
    {
        static void Main()
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            Console.Write("Original array:");
            foreach (var element in values)
            {
                Console.Write($" {element}");
            }

            var filtered =
                from value in values
                where value > 4
                select value;

            Console.Write("\nArray values greater than 4:");
            foreach (var element in filtered)
            {
                Console.Write($" {element}");
            }

            var sorted =
                from value in values
                orderby value
                select value;

            Console.Write("\nOriginal array, sorted:");

            foreach (var element in sorted)
            {
                Console.Write($" {element}");
            }

            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (two queries):");
            foreach (var element in sortFilteredResults)
            {
                Console.Write($" {element}");
            }

            var sortAndFilter =
                from value in values
                where value > 4
                orderby value descending
                select value;

            Console.Write("\nValues greater than 4, descending order (one query):");
            foreach (var element in sortAndFilter)
            {
                Console.Write($" {element}");
            }

            Console.WriteLine();
        }
    }
}