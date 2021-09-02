using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account : IAccountable
    {
        protected String Iban { get; set; }
        protected String Balance { get; set; }

        public Account(String Iban, String Balance)
        {
            this.Iban = Iban;
            this.Balance = Balance;
        }

        public void AddAcount()
        {
            throw new NotImplementedException();
        }

        public void deleteAccount()
        {
            throw new NotImplementedException();
        }
    }
}
