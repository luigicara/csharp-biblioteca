using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {
        public int Length { get; set; }

        public Dvd() : base() 
        {
            Console.WriteLine("Insert document's length in minutes!");

            int length;
            while (!int.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Insert NUMBER");
            Length = length;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Length: {Length}");
        }
    }
}
