using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public int NumberOfPages { get; set; }

        public Book(string code, string title, int year, string category, int shelf, string author, int numberOfPages) : base(code, title, year, category, shelf, author)
        {
            NumberOfPages = numberOfPages;
        }

        public Book() : base() {
            Console.WriteLine("Insert document's number of pages!");

            int numberOfPages;
            while (!int.TryParse(Console.ReadLine(), out numberOfPages))
                Console.WriteLine("Insert NUMBER");
            NumberOfPages = numberOfPages;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Number of pages: {NumberOfPages}");
        }
    }
}
