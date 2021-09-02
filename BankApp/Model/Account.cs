using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        protected String Iban { get; set; }
        protected String Balance { get; set; }

        public Account(String Iban, String Balance)
        {
            this.Iban = Iban;
            this.Balance = Balance;
        }
    }
}
