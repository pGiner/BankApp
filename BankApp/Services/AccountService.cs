using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class AccountService : IAccountable
    {
        NotificationService service = new NotificationService();

        public void AddAcount(List<Account> accountList, Account account)
        {
            accountList.Add(account);
            service.AccountCreatedNotification(account);

        }

        public void DeleteAccount(List<Account> accountList, Account account)
        {
            accountList.Remove(account);
            service.AccountDeletedNotification(account);
        }
    }
}
