using BankApp.Interfaces;
using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class MovementService : IAccountable
    {

        NotificationService service = new NotificationService();
        public void DepositMoney(Account account, decimal amount)
        {
            account.Balance += amount;
            service.Notification($"{amount} deposited in the account {account.Iban}, your balance is {account.Balance}");
        }

        public void RequestMoney(Account account, decimal amount, Account destinationAccount)
        {
            if (destinationAccount.Balance >= amount)
            {
                account.Balance += amount;
                destinationAccount.Balance -= amount;
                service.Notification($"{amount} requested to {destinationAccount.Iban}");
                
            }
            else
            {
                service.Notification($"Error, not enough money in account nº {destinationAccount.Iban}");
            }
            
        }

        public void TransferMoney(Account account, decimal amount, Account destinationAccount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                destinationAccount.Balance += amount;
                service.Notification($"{amount} transfered to account nº {destinationAccount.Iban}, your balance is {account.Balance}");
            }
            else
            {
                service.Notification($"Error, not enough money in account nº {account.Balance}");
            }

        }

        public void WithdrawMoney(Account account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                service.Notification($"{amount} withdrawed from your account, your balance is {account.Balance}");
            }
            else
            {
                service.Notification($"Error, not enough money in account nº {account.Iban}");
            }

        }
    }
}
