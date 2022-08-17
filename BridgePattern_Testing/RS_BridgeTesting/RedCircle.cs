using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_BridgeTesting
{
    public class RedCircle : ITheDraw
    {
        public void drawShape(int size)
        {
            Console.WriteLine($"Drawing Red Circle Size:{size}");
        }//end draw
    }//end class
}