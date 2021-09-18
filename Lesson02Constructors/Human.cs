using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Constructors
{
    class Human
    {
        // Member variable/ global variable/ field
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // Constructor - has to be public, has to be the same name as class name
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // Use 'this' to refer to the variable belonging to this object/ class (to the global variable/ field)
            /* Global variable/ field ->*/this.firstName = firstName;/*<- Local(constructor) variable*/
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // Member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName} and I'm {age} years old. The color of my eyes is {eyeColor}.");
        }
    }
}
