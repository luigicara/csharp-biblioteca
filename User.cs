using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public User() {

            Console.WriteLine("Insert your first name!");

            FirstName = Console.ReadLine();

            Console.WriteLine("Insert your last name!");

            LastName = Console.ReadLine();

            Console.WriteLine("Insert your email!");

            Email = Console.ReadLine();

            Console.WriteLine("Insert your password!");

            Password = Console.ReadLine();

            Console.WriteLine("Insert your phone number!");

            PhoneNumber = Console.ReadLine();
            
        }
    }
    
}
