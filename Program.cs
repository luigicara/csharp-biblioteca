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

            library.AddChoice();

            var document = library.SearchDocument();

            while (document == null)
            {
                Console.WriteLine("No documents found! Please retry!");

                document = library.SearchDocument();
            } 

            document.PrintInfo();

            if (Lending.LendingChoice())
            {
                Lending lending = new(user, document);

                library.AddLending(lending);

                Lending result = library.SearchLendings();

                result.PrintInfo();
            }
        }
    }
}