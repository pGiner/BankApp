using BankApp.Interfaces;
using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class MovementService : IClientable
    {

        NotificationService service = new NotificationService();
        public void DepositMoney(Account account, decimal amount)
        {
            
            account.Balance += amount;
            service.DepositNotification(account, amount);
        }

        public void RequestMoney(Account account, decimal amount, Account destinationAccount)
        {
            if (destinationAccount.Balance >= amount)
            {
                account.Balance += amount;
                destinationAccount.Balance -= amount;
                service.RequestNotification(account, destinationAccount, amount);
                
            }
            else
            {
                service.ErrorNotification();
            }
            
        }

        public void TransferMoney(Account account, decimal amount, Account destinationAccount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                destinationAccount.Balance += amount;
                service.TransferCreatedNotification(account, destinationAccount, amount);
            }
            else
            {
                service.ErrorNotification();
            }

        }

        public void WithdrawMoney(Account account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                service.WithdrawNotification(account, amount);
            }
            else
            {
                service.ErrorNotification();
            }

        }
    }
}
