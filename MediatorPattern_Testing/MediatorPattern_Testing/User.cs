using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Testing
{
    public class User
    {
        private string name;

        public User(string name_)
        {
            name = name_;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name_)
        {
            name = name_;
        }

        public void sendMessage(string message_)
        {
            //Allows the Communication Of Chat Room, blocking the coder from calling it without user
            new ChatRoom().showMessage(this, message_);
        }
    }
}