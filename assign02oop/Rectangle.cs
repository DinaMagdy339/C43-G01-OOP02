using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign02oop
{
    internal struct Rectangle
    {
        #region Attributes
        private double width;
        private double height;

        #endregion

        #region Constructors
        public Rectangle(double Width , double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        #endregion

        #region Setter - Getter 
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Height cannot be negative.");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area
        {
            get { return width * height; }
        }


        #endregion

        #region Method
        public void DisplayInfo()
        {
            if (width > 0 && height > 0)
                Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
            else
                Console.WriteLine("Can't calculate the area");
        }
        #endregion


    }
}
