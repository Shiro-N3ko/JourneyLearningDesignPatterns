using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_BridgeTesting
{
    public abstract class Shape
    {
        protected ITheDraw drawInfo;

        public Shape(ITheDraw drawInfo_)
        {
            drawInfo = drawInfo_;
        }

        public abstract void Draw();
    }
}