namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main()
        {
            Library library = new Library("Libreria");

            Console.WriteLine("Hello user, please insert your credentials");
            
            User user = new User();

            library.AddUser(user);

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
                    library.AddBook(book);
                    break;
                default:
                    Dvd dvd = new Dvd();
                    library.AddDvd(dvd);
                    break;
            }

            var document = library.SearchDocument();

            while (document == null)
            {
                Console.WriteLine("No documents found! Please retry!");

                document = library.SearchDocument();
            } 

            document.PrintInfo();

            Console.WriteLine("Do you wanna borrow the document? (y/n)");

            string lendingChoice = Console.ReadLine();

            while(lendingChoice != "y" && lendingChoice != "n")
            {
                Console.WriteLine("Input not valid!");

                lendingChoice = Console.ReadLine();
            }

            if (lendingChoice == "y")
            {
                Lending lending = new(user, document);
                library.AddLending(lending);

                Console.WriteLine("Complete! You ordered the book!");

                Lending result = library.SearchLendings();

                result.PrintInfo();
            }
        }
    }
}