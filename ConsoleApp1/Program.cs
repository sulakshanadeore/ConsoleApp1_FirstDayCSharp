using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsContd
{
    internal class Program
   {
     
        static void Main(string[] args)
        {

            // BxoingAndUnboxingDemo();
            // DynamicVarObjectDataTypesDemo();

            Student s = new Student();
            char userAns;
            do
            {
 
                s.NewStudent();

                Console.WriteLine("Do u want to add one more student");
                userAns = Convert.ToChar(Console.ReadLine());
              
            }
            while (userAns == 'Y');
            if (userAns != 'Y' || userAns != 'y')
            {
                Environment.Exit(0);
            }







        }

        


        private static void DynamicVarObjectDataTypesDemo()
        {
            //var and dynamic
            //object o = new DateTime(2025, 08, 09);
            //Console.WriteLine(o);
            //o = 1000;
            //Console.WriteLine(o);


            //Implicitly typed variable(The value assigned to it decides the datatype)
            //  var i = "Hello";
            //  //Now i can only hold string values.

            // // dynamic price = 3344;

            //  dynamic  price = "Hello";

            ////  price= new DateTime(2025, 08, 09);

            //  object obj = "Hello";//object checks the type at compile time


            //  string s = (string)obj;

            //  Console.WriteLine("string =" + s.Length);
            //  Console.WriteLine("Dynamic=" + price.Length);//Dynamic checks type at runtime




            object o = 100;
            dynamic d = 200;

            d = (int)o + d;//Requires casting as we are adding object and dynamic
            Console.WriteLine(d);

            dynamic d1 = 100;
            int i = 500;
            d1 = d1 + i;
            Console.WriteLine(d1);

            //Dynamic and object types can be used as parameters to a method, but var cannot be used as parameter in  a method.
        }

        private static void BxoingAndUnboxingDemo()
        {
            int i = 1000;

            object o = i;//Boxing---Smaller type(must be value type) assignment to bigger type(object type)

            Console.WriteLine(o.GetType());//Int32
            //Un-box---> remove from the box----take to original type
            int k = (int)o;
        }
    }
}
