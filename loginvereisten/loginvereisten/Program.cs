namespace loginvereisten
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string usernameInput;
            string passwordInput;

            const string user = "SXC0118T", password = "Wachtwoord123!";
            int tries = 0;
            while (tries < 3)
            {

                Console.Write("Gebruikersnaam: ");
                usernameInput = Console.ReadLine();

                Console.Write("Wachtwoord: ");
                passwordInput = Console.ReadLine();

                if (usernameInput == user && passwordInput == password)
                {
                    Console.WriteLine($"Welkom {user}!");
                }
                tries++;
                Console.WriteLine($"Foutieve login.\n {3 - tries} pogingen over.");
            }
            }
        }
    }
}
