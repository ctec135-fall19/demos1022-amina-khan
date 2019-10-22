using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class GrandChild : Child
    {
        // Demonstrate overriding a base class method by a child

        public override void SomeMethod()
        {
            Console.WriteLine("GrandChild's SomeMethod");
        }

        // Demo  a child calling the parents method
        public override void Method2()
        {
            base.Method2();     // base is Child in this case
            Console.WriteLine("GrandChild.Method2");

        }

        public void SpecializedMethod()
        {
            Console.WriteLine("SpecializedMethod in GrandChild");
        }
    }
}
