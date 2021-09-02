using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BankApp
{
    class Employee : User
    {
        public Employee(String Name, String Username, String Password)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
