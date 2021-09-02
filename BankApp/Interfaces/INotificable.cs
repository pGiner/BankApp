using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface INotificable
    {
        public void AccountCreatedNotification(Account account);
        public void AccountDeletedNotification(Account account);
        public void DepositNotification(Account account, decimal amount);
        public void RequestNotification(Account account, Account destinationAccount, decimal amount);
        public void TransferCreatedNotification(Account account, Account destinationAccount, decimal amount);
        public void WithdrawNotification(Account account, decimal amount);
        public void ErrorNotification();
    }
}
