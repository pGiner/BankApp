using BankApp.Interfaces;
using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class NotificationService : INotificable
    {
        public void AccountCreatedNotification(Account account)
        {
            System.Console.WriteLine($"{account.Iban} account created succesfully");
        }

        public void AccountDeletedNotification(Account account)
        {
            System.Console.WriteLine($"{account.Iban} account deleted succesfully");
        }

        public void DepositNotification(Account account, decimal amount)
        {
            System.Console.WriteLine($"{amount} deposited in your account, your balance is {account.Balance}");
        }

        public void RequestNotification(Account account, Account destinationAccount, decimal amount)
        {
            System.Console.WriteLine($"{amount} requested to {destinationAccount.Iban}, your balance is {account.Balance}");
        }

        public void TransferCreatedNotification(Account account, Account destinationAccount, decimal amount)
        {
            System.Console.WriteLine($"{amount} transfered to {destinationAccount.Iban}, your balance is {account.Balance}");
        }

        public void WithdrawNotification(Account account, decimal amount)
        {
            System.Console.WriteLine($"{amount} withdrawed, your balance is {account.Balance}");
        }

        public void ErrorNotification()
        {
            System.Console.WriteLine("An error ocurred");
        }
    }
}
