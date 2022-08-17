using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Testing
{
    public class Memento
    {
        private string state;

        public Memento(string state_)
        {
            state = state_;
        }

        public string getState()
        {
            return state;
        }
    }
}