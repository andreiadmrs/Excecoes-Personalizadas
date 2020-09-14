using System;
using System.Globalization;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Excepctions;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data: ");
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Holder: ");
            string holder = Console.ReadLine();
            Console.WriteLine("Initional Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine("Enter amount to withdraw: ");
            double widthdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(widthdraw);

                Console.WriteLine(account);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

