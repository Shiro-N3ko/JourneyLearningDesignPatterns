using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Testing
{
    public class Originator
    {
        private string theState;

        public void setState(string state_)
        {
            theState = state_;
        }

        public string getState()
        {
            return theState;
        }

        public Memento saveStateToMemory()
        {
            return new Memento(theState);
        }

        public void getStateFromMemory(Memento memento)
        {
            theState = memento.getState();
        }
    }
}