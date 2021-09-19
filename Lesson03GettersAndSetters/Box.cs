using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03GettersAndSetters
{
    class Box
    {
        private int length;
        private int width;
        public int Height { get; set; }
        //public int height;
        //public int volume;

        public Box(int length, int width, int height)
        {
            this.length = length;
            Width = width;
            Height = height;

        }

        public void SetLength(int length)
        {
            if(length < 1)
            {
                throw new Exception("Length has to be 1 or larger.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }


        public int Volume 
        { 
            get
            {
                return this.length * this.width * this.Height;
            }
        }

        public void DisplayVolume()
        {
            Console.WriteLine($"The volume of the box is {length * width * Height}.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The length of the box is {length}, the width is {width}, the height is {Height} and the volume is {Volume}.");
        }
    }
}
