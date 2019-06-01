using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVSolution
{
    class Rectangle:IPolygon
    {
        private double _height, _width;
        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }

        public  void SetWidth(double width)
        {
            this._width = width;
        }
        public  void SetHeight(double Height)
        {
            this._height = Height;
        }
        public double GetWidth()
        {
            return _width;
        }
        public double GetHeight()
        {
            return _height;
        }

        public double CalculateArea()
        {
            return _width * _height;
        }
    }
}
