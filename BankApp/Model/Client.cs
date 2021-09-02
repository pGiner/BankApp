using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BankApp.Model
{
    class Client : User
    {
        List<Account> accountList { get; set; }
        public Client(String Name, String Username, String Password, List<Account> AccountList)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            accountList = AccountList;
        }

        
    }
}
