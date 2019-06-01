using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVSolution
{
    class Square
    {
        private double _side;
        public Square(double side)
        {
            this._side = side;
        }

        public void SetSide(double side)
        {
            _side = side;
        }
        public double GetSide()
        {
            return _side * _side;
        }
    }
}
