using System;
using System.Collections.Generic;
using System.Globalization;
using ExcecoesPersonalizadas.Entities.Excepctions;

namespace ExcecoesPersonalizadas.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            if (WithdrawLimit < withdraw)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (Balance < withdraw)
            {
                throw new DomainException("Not enough balance.");
            }
            else
            {
                Balance -= withdraw;
            }
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
