using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IAccountable
    {
        public void DepositMoney(Account account, decimal amount);
        public void RequestMoney(Account account, decimal amount, Account destinationAccount);
        public void TransferMoney(Account account, decimal amount, Account destinationAccount);
        public void WithdrawMoney(Account account, decimal amount);
    }
}
