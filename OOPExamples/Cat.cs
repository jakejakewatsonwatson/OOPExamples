using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class Cat : Animal
    {
        //This is an example of polymophism
        public Cat(string name)
        {
            SetName(name);
        }
        public new void SetNumberofLegs(int legs)
        {
            if (legs > 5)
            {
                numOfLegs = 4;
            }
            numOfLegs = legs;
        }
        //this is an example of encapsulation
        public string Bark()
        {
            return getMessage();
        }
        private string getMessage()
        {
            string name = GetName();
            int legs = GetNumberOfLegs();
            return "My name is " + name + " I have " + legs + " legs";
        }
    }
}
