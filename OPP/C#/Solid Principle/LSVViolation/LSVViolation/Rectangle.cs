using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVViolation
{
    class Rectangle
    {
        protected int _height, _width;
        public Rectangle(int height,int width)
        {
            this._height = height;
            this._width = width;
        }
        public virtual void  SetHeight(int height)
        {
            this._height = height;
        }
        public  virtual void SetWidth(int width)
        {
            this._width = width;
        }
        public int GetWidth()
        {
            return _width;
        }
     
        public int GetHeight()
        {
            return _height;
        }
        public int CalculateArea()
        {
            return _height * _width;
        }

    }
}
