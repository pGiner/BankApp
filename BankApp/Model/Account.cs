using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        public String Iban { get; set; }
        public decimal Balance { get; set; }

        public Account(String Iban, String Balance)
        {
            this.Iban = Iban;
            this.Balance = Balance;
        }

    }
}
