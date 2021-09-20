using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Members
{
    class Members
    {
        // Member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // Member - public field
        public int age;

        // Member - public property - exposes jobTitle safely - properties use PascalCase
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Member - public method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, and I am {JobTitle}. I am {age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}.");
        }

        // Member - constructor
        public Members()
        {
            Console.WriteLine("Object created.");
        }

        // Member - deconstructor - finalizer
        ~Members()
        {
            Console.WriteLine("Destruction of Members object!");
            Debug.Write("Proof of destruction.");
        }
    }
}
