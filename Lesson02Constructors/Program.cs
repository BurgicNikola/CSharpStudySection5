﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human nikola = new Human("Nikola", "Burgic", "brown", 30);
            nikola.IntroduceMyself();

            Human peter = new Human("Peter", "McDude", "green", 55);
            peter.IntroduceMyself();

            Console.ReadLine();
        }
    }
}
