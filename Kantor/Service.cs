using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    internal class Service
    {
        private static int sessionID;
        public static List<Account> Accounts = new List<Account>();
        private static Account currentAccount = null;
        public static List<Currency> Currencies = new List<Currency>();

        public static void initialize()
        {
            Random rand = new Random();
            sessionID = rand.Next(1, 100000);
            new Currency("Polski Złoty", 1.00, "PLN");
            new Currency("Euro", (double)rand.Next(450, 493)/100, "EUR");
            new Currency("Dolar amerykański", (double)rand.Next(440, 460) / 100, "USD");
            new Currency("Frank szwajcarski", (double)rand.Next(440, 480) / 100, "CHF");
        }

        public static void register()
        {
            Console.WriteLine("Podaj login: ");
            string login = Console.ReadLine();
            while(login.Trim() == "" || login == null)
            {
                login = Console.ReadLine();
            }
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();
            while(password.Trim() == "" || login == null)
            {
                password = Console.ReadLine();
            }
            Account account = new Account(login, password);
            currentAccount = account;
            Console.WriteLine("Pomyślnie zarejestrowano użytkownika o id: " + account.getId() + " oraz loginie: " + account.getName());
            menu();

        }

       public static void menu()
        {

        }
    }
}
