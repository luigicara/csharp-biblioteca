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

            if (document == null)
            {
                Console.WriteLine("No documents found!");
            } else
            {
                document.PrintInfo();
            } 
        }
    }
}