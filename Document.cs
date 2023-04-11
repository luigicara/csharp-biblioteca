using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public int Shelf { get; set; }  
        public string Author { get; set; }

        public Document()
        {
            Console.WriteLine("Insert document's code!");

            Code = Console.ReadLine();

            Console.WriteLine("Insert document's title!");

            Title = Console.ReadLine();

            Console.WriteLine("Insert document's year of pubblication");

            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
                Console.WriteLine("Insert NUMBER");
            Year = year;

            Console.WriteLine("Insert document's category!");

            Category = Console.ReadLine();

            Console.WriteLine("Insert document's shelf!");

            int shelf;
            while (!int.TryParse(Console.ReadLine(), out shelf))
                Console.WriteLine("Insert NUMBER");
            Shelf = shelf;

            Console.WriteLine("Insert document's author full name!");

            Author = Console.ReadLine();
        }

        public Document(string code, string title, int year, string category, int shelf, string author)
        {
            Code = code;
            Title = title;
            Year = year;
            Category = category;
            Shelf = shelf;
            Author = author;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Here we go!\r\n");
            Console.WriteLine($"Code: {Code}\r\nTitle: {Title}\r\nYear: {Year}\r\nCategory: {Category}\r\nShelf: {Shelf}\r\nAuthor: {Author}");
        }
    }
}
