using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBased
{
    public class base_and2Drives
    {
        public class Grandparent
        {
            public Grandparent()
            {
                Console.WriteLine("\nGrandparent to Child family");
            }
            public void DisplayGrandParents()
            {
                Console.WriteLine("VNR & VCM my grandparents");
            }
        }

        public class Parents : Grandparent
        {
            public void DisplayParents()
            {
                Console.WriteLine(" VBR & VDM my parents ");
            }
        }

        public class Child : Parents
        {
            public void DisplayChild()
            {
                Console.WriteLine("I am the child Balu");
            }
        }
    }
}
