using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length, width;

        //defualt constructor (sets the values to 1)
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        //sets the values to whatever the user defines
        public Rectangle(int inputLength, int inputWidth)
        {
            length = inputLength;
            width = inputWidth;
        }

        //returns the length of the rectangle
        public int GetLength()
        {
            return length;
        }
        //returns the width
        public int GetWidth()
        {
            return width;
        }
        //sets the length with the users input and returns it
        public int setLength(int length)
        {
            this.length = length;
            return length;
        }
        //sets the width with the users input and returns it
        public int setWidth(int width)
        {
            this.width = width;
            return width;
        }
        //returns all dimension values summed up
        public int getPerimeter()
        {
            return (length * 4) + (width * 2);
        }

        //returns the area of the rectangle 
        public int getArea()
        {
            return length * width;
        }

        public int MutatedGetLength()
        {
            return length;
        }
        //returns the width
        public int MutatedGetWidth()
        {
            return width;
        }
        //sets the length with the users input and returns it
        public int MutatedsetLength(int length)
        {
            this.length = this.width;
            return length;
        }
        //sets the width with the users input and returns it
        public int MutatedsetWidth(int width)
        {
            if (width > 0)
            {
                this.width = this.length;
            }
            return width;
        }
        //returns all dimension values summed up
        public int MutatedgetPerimeter()
        {
            if((length * width) > 0)
            {
                return (length * 2) + (width * 5);
            }
            else
            {
                return this.length;
            }
        }

        //returns the area of the rectangle 
        public int MutatedgetArea()
        {
            return length * width;
        }
    }
}
