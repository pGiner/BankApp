using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IClientable
    {
        public void TransferMoney();
        public void RequestMoney();
        public void DepositMoney();
        public void WithdrawMoney();
    }
}
