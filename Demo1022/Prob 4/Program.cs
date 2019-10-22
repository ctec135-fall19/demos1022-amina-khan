using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 & 2");


            #region An array of the base class type is created and 
            //initialized with a member of each class in the hierarchy

            Parent[] myArray = new Parent[3];
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new GrandChild();

            // Show that a method belonging to the base class is 
            // called from a child instance
            // create ParenMethod() in Parent and iterate through array
            // calling this method to demonstrate that all child classes
            // have access to it

            foreach (Parent element in myArray)
            {
                Console.WriteLine("{0}: ", element.GetType());
                element.ParentMethod();
            }

            #endregion

            Console.WriteLine("3");

            #region Demonstrate overriding a base class method by a child
            // Parent 

            foreach (Parent element in myArray)
            {
                Console.WriteLine("{0}: ", element.GetType());
                element.SomeMethod();
            }

            #endregion

            Console.WriteLine("4");
            
            #region Demonstrate a child method calling the parent's method
            // create a virtual method in parent
            // override in child and call th eparent as part of implementation
            

            foreach (Parent element in myArray)
            {
                Console.WriteLine("{0}:  ", element.GetType());
                element.Method2();
                Console.WriteLine();
            }

            #endregion


            Console.WriteLine("5");

            #region  Demonstrate use of "as" keyword
            // repeat calls to SomeMethod
            foreach (object element in myArray)
            {
                Parent p = element as Parent;  // implicit casting
                //Parent p = (Parent)element; // explicit cast, same as line above
                Console.WriteLine("{0}: ", p.GetType());
                p.SomeMethod();

            }
            # endregion
            Console.WriteLine("6");

            #region  Demonstrate use of "is" keyword
            //Demonstrate use of "is" keyword
            Console.WriteLine("Demo use of is");
            foreach (Parent element in myArray)
            {
                if (element is GrandChild) Console.WriteLine("GrandChild");
                else if (element is Child) Console.WriteLine("Child");
                else if (element is Parent) Console.WriteLine("Parent");

            }
            #endregion

            #region switch
            Console.WriteLine("switch");

            foreach (Parent element in myArray)
            {
                switch (element)
                {
                    case GrandChild gc:
                        Console.WriteLine("GrandChild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }

            #endregion

            #region Create an object of "object" type, but initialized of 
            //the base class type, then cast it to the actual type so you 
            //can call a method

            object obj = new Parent();
            ((Parent)obj).ParentMethod(); //explicit casting and how to use it

            #endregion

            #region specialized method
            Parent p2 = new GrandChild();
            ((GrandChild)p2).SpecializedMethod();

            #endregion


        }
    }
}
