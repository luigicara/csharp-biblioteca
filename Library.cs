using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_biblioteca
{
    internal class Library
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Document> Documents { get; set; }
        public List<Lending> Lendings { get; set; }

        public Library(string name)
        {
            Name = name;
            Users = new List<User>();
            Documents = new List<Document>();
            Lendings = new List<Lending>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddBook(Book book)
        {
            Documents.Add(book);
        }

        public void AddDvd(Dvd dvd)
        {
            Documents.Add(dvd);
        }

        public void AddLending(Lending lending)
        {
            Lendings.Add(lending);

            Console.WriteLine("Complete! You ordered the book!");
        }

        public Document? SearchDocument()
        {
            Console.WriteLine("Do you want to search by code or title (code/title)");

            string choice = Console.ReadLine() ?? string.Empty;

            while (choice != "code" && choice != "title")
            {
                Console.WriteLine("Input not valid!");

                choice = Console.ReadLine() ?? string.Empty;
            }

            Document result;

            bool error = false;
            
            do
            {
                if (error)
                    Console.WriteLine("No documents found. Please, try again!");

                Console.WriteLine($"Enter {choice}");

                string query = Console.ReadLine() ?? string.Empty;

                if (choice == "code")
                    result = Documents.Find(x => x.Code == query);
                else
                    result = Documents.Find(x => x.Title == query);

                error = true;
            } while (result == null);
            
            return result; 

        }

        public Lending SearchLendings()
        {
            Lending result;

            bool error = false;

            do
            {
                if (error)
                    Console.WriteLine("No lendings found by this name. Please, try again!");
                else
                    Console.WriteLine("Search by your name!");

                Console.WriteLine("Enter first name");

                string firstName = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Enter last name");

                string lastName = Console.ReadLine() ?? string.Empty;

                result = Lendings.Find(x => x.User.FirstName == firstName && x.User.LastName == lastName);

                error = true;
            } while (result == null);

            return result;
        }

        public void AddChoice()
        {
            Console.WriteLine("Do you wanna add DVD or Book? (dvd/book)");

            string choice = Console.ReadLine();

            while (choice != "dvd" && choice != "book" && choice != null)
            {
                Console.WriteLine("Input not valid!");

                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "book":
                    Book book = new Book();
                    this.AddBook(book);
                    break;
                default:
                    Dvd dvd = new Dvd();
                    this.AddDvd(dvd);
                    break;
            }
        }
    }
}
