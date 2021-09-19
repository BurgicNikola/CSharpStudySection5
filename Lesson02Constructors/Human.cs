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

        public Human()
        {
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, int age)
        {
            this.firstName = firstName;
            this.age = age;
        }

        // Member method
        public void IntroduceMyself()
        {
            if (age > 0 && firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName} and I'm {age} years old. The color of my eyes is {eyeColor}.");
            }
            else if (firstName != null && lastName != null && age <= 0 && eyeColor == null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.");
            }
            else if(firstName != null && lastName == null && age > 0 && eyeColor == null)
            {
                Console.WriteLine($"Hi, I'm {firstName} and I'm {age} years old.");
            }
            else if(age <= 0 && firstName != null && lastName == null && eyeColor == null)
            {
                Console.WriteLine($"Hi, I'm {firstName}.");
            }
            else
            {
                Console.WriteLine("Hi!");
            }
        }
    }
}
