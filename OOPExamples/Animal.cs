using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class Animal
    {
        //this is an example of abstraction
        public int numOfLegs;
        public string Name;

        public void SetNumberofLegs(int legs)
        {
            numOfLegs = legs;
        }
        public int GetNumberOfLegs()
        {
            return numOfLegs;
        }
        public void SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                Name = "Optimus Prime";
            }
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
