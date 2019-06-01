using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVViolation
{
    class Square : Rectangle
    {
        private int _side;
        public Square(int side) : base(side, side)
        {
            this._height = this._width = side;
        }
        public override void SetWidth(int width)
        {
            this._height = this._width = width;
        }
        public override void SetHeight(int height)
        {
            this._height = this._width = height;
        }
    }
}
