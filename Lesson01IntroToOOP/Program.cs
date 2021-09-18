using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // An object of Human class/ an instance of Human
            Human nikola = new Human();

            // Access and edit a variable from outside
            nikola.firstName = "Nikola";
            // Call the method from the class
            nikola.IntroduceMyself();

            Human pera = new Human();
            // There is no need to set the firstName since the default value is already set to Pera
            pera.IntroduceMyself();

            Human zika = new Human();
            zika.firstName = "Zika";
            zika.lastName = "Jovanovic";
            zika.IntroduceMyself();

            Human mika = new Human();
            zika.firstName = "Mika";
            zika.lastName = "Milovanovic";
            zika.IntroduceMyself();

            Console.ReadLine();
        }
    }
}
