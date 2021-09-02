using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class NotificationService : INotificable
    {
        public String NotificationText;

        public NotificationService(String NotificationText)
        {
            this.NotificationText = NotificationText;
        }

        public string notification()
        {
            throw new NotImplementedException();
        }
    }
}
