using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Lending
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }

        public Lending(User user, Document document)
        {
            User = user;
            Document = document;

            Console.WriteLine("Insert start date! (dd/mm/yyyy)");

            StartTime = Console.ReadLine();

            Console.WriteLine("Insert end date! (dd/mm/yyyy)");

            EndTime = Console.ReadLine();
        }

        public void PrintInfo()
        {
            Console.WriteLine("Here we go!\r\n");
            Console.WriteLine($"Start Time: {StartTime}\r\nEnd Time: {EndTime}\r\nUser: {User.FirstName} {User.LastName}\r\nDocument: {Document.Code} {Document.Title}");
        }


        public static bool LendingChoice()
        {
            Console.WriteLine("Do you wanna borrow the document? (y/n)");

            string lendingChoice = Console.ReadLine();

            while (lendingChoice != "y" && lendingChoice != "n")
            {
                Console.WriteLine("Input not valid!");

                lendingChoice = Console.ReadLine();
            }

            if (lendingChoice == "y")
                return true;

            return false;
        }
    }
}
