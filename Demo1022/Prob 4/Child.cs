using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Child : Parent
    {
        // Demonstrate overriding a base class method by a child

        public override void SomeMethod()
        {
            Console.WriteLine("Child's SomeMethod");
        }

        // Demo  a child calling the parents method
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Child.Method2");

        }
    }
}
