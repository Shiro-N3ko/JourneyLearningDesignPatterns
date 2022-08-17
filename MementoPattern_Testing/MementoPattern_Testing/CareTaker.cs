using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Testing
{
    public class CareTaker
    {
        //the saved states
        private List<Memento> mementoContainer = new List<Memento>();

        public void add(Memento aMemento)
        {
            mementoContainer.Add(aMemento);
        }

        public Memento get(int index)
        {
            return mementoContainer[index];
        }
    }
}