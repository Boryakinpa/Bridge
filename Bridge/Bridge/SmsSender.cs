using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка SMS: {message}");
        }
    }
}
