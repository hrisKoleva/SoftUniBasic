using System;

namespace PasswordGuess
{
    class GuessThePassword
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string login = Console.ReadLine();

            if(password.Equals(login))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
