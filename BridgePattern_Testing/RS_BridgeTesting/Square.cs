using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_BridgeTesting
{
    public class Square : Shape
    {
        private int size;

        public Square(int size_, ITheDraw drawInfo_) : base(drawInfo_)
        {
            size = size_;
        }

        public override void Draw()
        {
            drawInfo.drawShape(size);
        }
    }
}