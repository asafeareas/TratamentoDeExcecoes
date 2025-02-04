using System;
using System.Globalization;

namespace Tratamento {
    class Program {
        public static void Main(string[]args) {
            Console.WriteLine("ENTER ACCOUNT DATA");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.WriteLine("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                acc.withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            } catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

