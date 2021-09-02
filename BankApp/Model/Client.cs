using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BankApp.Model
{
    class Client : User
    {
        List<Account> accountList { get; set; }
        public Client(string Name, string Username, SecureString Password, List<Account> AccountList)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            accountList = AccountList;
        }

        
    }
}
