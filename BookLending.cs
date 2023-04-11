using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class BookLending
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }

        public BookLending(User user, Document document)
        {
            User = user;
            Document = document;

            Console.WriteLine("Insert start date! (dd/mm/yyyy)");

            StartTime = Console.ReadLine();

            Console.WriteLine("Insert end date! (dd/mm/yyyy)");

            StartTime = Console.ReadLine();
        }
    }
}
