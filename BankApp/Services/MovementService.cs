using BankApp.Interfaces;
using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class MovementService : IClientable
    {
        public void DepositMoney(Account account, decimal amount)
        {
            account.Balance += amount;

            // TODO: Implement notification service 
        }

        public void RequestMoney(Account account, decimal amount, Account destinationAccount)
        {
            // TODO: Implement a petition and wait
            if (destinationAccount.Balance >= amount)
            {
                account.Balance += amount;
                destinationAccount.Balance -= amount;
            }
            else
            {
                //error notification
            }
            
        }

        public void TransferMoney(Account account, decimal amount, Account destinationAccount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                destinationAccount.Balance += amount;
            }
            else
            {
                //error notification
            }

        }

        public void WithdrawMoney(Account account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
            }
            else
            {
                //error notification
            }

        }
    }
}
