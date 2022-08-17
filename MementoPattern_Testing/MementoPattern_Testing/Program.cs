namespace MementoPattern_Testing
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            //THIS Will Not Save
            originator.setState("State 1: AKA Off");

            //saves this one
            originator.setState("State 2: Working");
            careTaker.add(originator.saveStateToMemory());

            //Print Without Saving
            originator.setState("State 3: Current");
            Console.WriteLine($"Current State Is:{originator.getState()}");

            //Save Second State
            originator.setState("State 4: Next");
            careTaker.add(originator.saveStateToMemory());
            Console.WriteLine($"Current State Is:{originator.getState()}");

            //remove current without saving
            originator.setState("State 5: Current");
            Console.WriteLine($"Current State Is:{originator.getState()}");

            //load first state from memento EDITORS NODE:  I Typoed this method name from memento to Memeory LMAO
            originator.getStateFromMemory(careTaker.get(0));
            Console.WriteLine($"First Saved State Is:{originator.getState()}");

            //load second
            originator.getStateFromMemory(careTaker.get(1));
            Console.WriteLine($"Second Saved State Is:{originator.getState()},");
        }
    }//end Program
}//end ns