using BankApp.Model;
using BankApp.Services;
using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("1234", 20);
            Account destinationAccount = new Account("5678", 100);
            List<Account> AccountList = new List<Account>();

            Client client = new Client("Pablo Giner", "pGiner","1234", AccountList);

            AccountService accountService = new AccountService();
            MovementService movementService = new MovementService();

            accountService.AddAcount(AccountList, account);

            movementService.DepositMoney(account, 20);

            movementService.RequestMoney(account, 20, destinationAccount);

            movementService.TransferMoney(account, 40, destinationAccount);

            movementService.WithdrawMoney(account, 10);
        }
    }
}
