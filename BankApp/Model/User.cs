using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace BankApp
{
    public abstract class User
    {
        protected String Name { get; set; }
        protected String Username { get; set; }
        protected String Password { get; set; }
    }

    
}
