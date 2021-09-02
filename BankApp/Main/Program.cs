using BankApp.Services;
using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MovementService service = new MovementService();
            Account account = new Account("1234", 20);
            Account destinationAccount = new Account("5678", 100);
            service.DepositMoney(account, 20);
            service.RequestMoney(account, 20, destinationAccount);
            service.TransferMoney(account, 40, destinationAccount);
            service.WithdrawMoney(account, 10);
        }
    }
}
