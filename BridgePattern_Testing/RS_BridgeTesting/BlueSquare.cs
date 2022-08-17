using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_BridgeTesting
{
    public class BlueSquare : ITheDraw
    {
        public void drawShape(int size)
        {
            Console.WriteLine($"Drawing Blue Square Size:{size}");
        }//end draw
    }
}