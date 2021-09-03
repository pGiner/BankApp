using BankApp.Interfaces;
using BankApp.Services;
using System;
using System.Collections.Generic;

namespace BankApp.Model
{
    class Client : User, IClientable
    {
        List<Account> AccountList { get; set; }
        public Client(String Name, String Username, String Password, List<Account> AccountList)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.AccountList = AccountList;
        }

        NotificationService service = new NotificationService();

        /// <summary>
        /// Metodo para añadir una cuenta a un usuario
        /// </summary>
        /// <param name="accountList">Listado de cuentas del cliente</param>
        /// <param name="account">Cuenta concreta creada para un cliente</param>
        public void AddAcount(List<Account> accountList, Account account)
        {
            accountList.Add(account);
            service.Notification($"Account nº {account.Iban} created");

        }

        /// <summary>
        /// Metdodo para eliminar la cuenta de un usuario
        /// </summary>
        /// <param name="accountList">Listado de cuentas del cliente</param>
        /// <param name="account">Cuenta concreta perteneciente a un cliente</param>
        public void DeleteAccount(List<Account> accountList, Account account)
        {
            accountList.Remove(account);
            service.Notification($"Account nº {account.Iban} deleted");
        }


    }
}
