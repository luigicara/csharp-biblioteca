﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        }

        public Document SearchDocument()
        {
            Console.WriteLine("Do you want to search by code or title (code/title)");

            string choice = Console.ReadLine();

            while (choice != "code" && choice != "title" && choice != null) { 
                Console.WriteLine("Input not valid!");

                choice = Console.ReadLine();    
            }

            switch (choice)
            {
                case "title":
                    Console.WriteLine("Enter Title");

                    string title = Console.ReadLine();

                    return Documents.Find(x => x.Title == title);
                default:
                    Console.WriteLine("Enter Code");

                    string code = Console.ReadLine();

                    return Documents.Find(x => x.Code == code);
            }

        }

        public Lending SearchLendings()
        {
            Console.WriteLine("\r\nSearch by your name!\r\nEnter first name");

            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");

            string lastName = Console.ReadLine();


            return Lendings.Find(x => x.User.FirstName == firstName && x.User.LastName == lastName);
        }
    }
}
