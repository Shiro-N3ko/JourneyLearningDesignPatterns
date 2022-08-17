using RS_HelperLibrary;

namespace RS_BridgeTesting
{
    public class BridgeTest
    {
        private static void Main(string[] args)
        {
            Shape redCircle = new Circle(10, new RedCircle());
            Shape greenCircle = new Circle(15, new GreenCircle());

            Shape blueSquare = new Square(25, new BlueSquare());

            redCircle.Draw();
            greenCircle.Draw();
            blueSquare.Draw();
        }
    }
}