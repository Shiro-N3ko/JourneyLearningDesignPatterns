using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_BridgeTesting
{
    public class Circle : Shape
    {
        private int size;

        public Circle(int size_, ITheDraw drawInfo_) : base(drawInfo_)
        {
            size = size_;
        }

        public override void Draw()
        {
            drawInfo.drawShape(size);
        }
    }
}