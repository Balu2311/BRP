using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBased
{
    public class multipleInhertances
    { 
        public class Father
        {
            public String familyName;
            public String houseaddress;
            public Father()
            {
                familyName = "Programmer";
                houseaddress = "Delhi";
            }
        }
        public class Son : Father
        {
            public Son()
            {
                Console.WriteLine("I am the Son");
                Console.WriteLine("My family name is " + this.familyName + " and I am from " + this.houseaddress);
            }
        }
        public class Daughter : Father
        {
           public Daughter()
            {
                Console.WriteLine("I am the Daughter");
                Console.WriteLine("My family name is " + this.familyName + " and I am from " + this.houseaddress);
            }
        }

    }

}


