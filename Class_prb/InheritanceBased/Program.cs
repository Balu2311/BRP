using System;
using static InheritanceBased.base_and2Drives;
using static InheritanceBased.multipleInhertances;

namespace InheritanceBased
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InheritanceBased");
            Son s = new Son();
            Daughter d = new Daughter();

            //base_and2Drives
            Child cd = new Child();
            cd.DisplayChild();
            cd.DisplayParents();
            cd.DisplayGrandParents();
        }
    }
}
