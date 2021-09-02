using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IAccountable
    {
        public void AddAcount(List<Account> accountList, Account account);

        public void DeleteAccount(List<Account> accountList, Account account);
    }
}
