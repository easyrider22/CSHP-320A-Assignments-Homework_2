using homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace homework2
{
    class Program
    {
        private const string V = "undefined";

        static void Main(string[] args)
        {

            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            // **homework2 Part_1**
            Console.WriteLine("Displaying names of the users where their password is \"hello\".");
            var passwordHello =
                from hello in users
                where hello.Password == "hello"
                select hello.Name;

            // foreach iteration to Display Names with password "hello"
            Console.WriteLine("Name(s) with \"Hello\" Passwords");
            int count = 1;
            foreach (var passName in passwordHello)
            {
                Console.WriteLine($"{count++}) {passName}");
                
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine();


            // **homework2 Part_2**
            Console.WriteLine("Deleting any passwords that are the lower-cased version of their UserName.");
            var passwordName =
             from pass in users
             where pass.Password == (string)pass.Name.ToLower()
             select pass.Password;
            users.RemoveAll(item => item == passwordName);

            // foreach iteration to Display Names that had lower-case password of their name. 
            int count3 = 1;
            foreach (var passName in passwordName)
            {
                Console.WriteLine($"{count3++}) Password \"{passName}\" has been removed");

            }
            Console.WriteLine("__________________________________");
            Console.WriteLine();


            // **homework2 Part_3**
            Console.WriteLine("Deleting the first User that has the password \"hello\", and");
            var find = users.FirstOrDefault(x => x.Password == "hello");
            if (find != null)
            {
                users.Remove(find);
            }

            // **homework2_Part4**
            Console.WriteLine("displaying the remaining users with their Name and Password.");
            Console.WriteLine("__________________________________");
            Console.WriteLine();

            // foreach iteration to Display remaining user Names and Passwords.
            int count4 = 1;
            Console.WriteLine("Remaining Users");
            foreach (var userName in users)
            {                
                Console.WriteLine($"{count4++}) Name: \"{userName.Name}\", Password: \"{userName.Password}\"");                
            }
        }
    }
}
