using BankApp.Interfaces;
using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class NotificationService : INotificable
    {
        public void Notification(String text)
        {
            System.Console.WriteLine(text);
        }
    }
}
