using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Testing
{
    public class ChatRoom
    {
        public void showMessage(User user_, string message_)
        {
            Console.WriteLine($"{new DateTime()}[{user_.getName()}]{message_}");
        }
    }
}