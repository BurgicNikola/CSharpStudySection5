using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(2,3,4);

            box.DisplayInfo();
            box.DisplayVolume();
            Console.WriteLine(box.FrontSurface);
            box.SetLength(9);
            box.Height = 2;
            box.Width = 5;

            box.DisplayInfo();
            box.DisplayVolume();



            Console.ReadLine();
        }
    }
}
