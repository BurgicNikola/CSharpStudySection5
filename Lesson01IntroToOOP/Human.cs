using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01IntroToOOP
{
    // This class is a blueprint for a datatype
    class Human
    {
        // Member variable
        // Every single Human will be called Pera unless the name is changed
        public string firstName = "Pera";
        public string lastName;

        // Member method
        public void IntroduceMyself()
        {
            if(lastName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.");
            }
            else
            {
                Console.WriteLine($"Hi, I'm {firstName}.");
            }
        }
    }
}
