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
            Box box = new Box();

            box.SetLength(9);
            box.height = 2;
            box.width = 5;

            box.DisplayInfo();
            box.DisplayVolume();

            Console.ReadLine();
        }
    }
}
