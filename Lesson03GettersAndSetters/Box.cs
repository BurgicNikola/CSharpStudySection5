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
        public int width;
        public int height;
        public int volume;

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

        public void DisplayVolume()
        {
            Console.WriteLine($"The volume of the box is {length * width * height}.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The length of the box is {length}, the width is {width}, the height is {height} and the volume is {length * width * height}.");
        }
    }
}
