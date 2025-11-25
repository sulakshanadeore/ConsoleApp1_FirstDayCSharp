using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Web;


namespace ConsoleApp1
{

    enum WeekDays
    { 
    Monday,
    Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    
    }


    enum OrderStatus
    { 
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
    }

    internal class Program
    {

      static void Add(int i, int j,out int ans) {
            ans = i + j;
        
        }



        //Calculate 4 values====Add,sub,mul,div
        //Accept 2 input parameters, and 4 output parameters
        static void Calculations(int a, int b, out int addans, out int subans, out int multans, out int divans)
        {
            addans = a + b;
            subans = a - b;

            if (a != 0 && b != 0)
            {
                multans = b * a;
            }
            else multans = 0;

            if (b != 0)
            {
                divans = a / b;
            }
            else
                divans = 0;

        }

        static void Main(string[] args)
        {
            //int==Int32
            //float==Single
            //double==Double
            //char==Char

            //Console.WriteLine("Enter a  number");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1);
            ////convert string to int
            //Console.WriteLine("Enter Y for Yes, and N for No");
            //char input=Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(input);

            //double price;
            //Console.WriteLine("Enter the price");
            //price=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(price);

            //bool userChoice;
            //Console.WriteLine("Enter true or false");
            //userChoice=Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(userChoice);

            //Console.WriteLine($"Current DateTime={DateTime.Now}");
            //Console.WriteLine($"Current DateTime UTC={DateTime.UtcNow}");
            //Console.WriteLine($"Today: {DateTime.Today}");

            //DateTime dt = new DateTime(2025, 11, 25, 3, 31, 00);
            //Console.WriteLine(dt);

            //DateTime c = DateTime.Now;
            //Console.WriteLine(c.ToString("dd-MM-yyyy"));
            //Console.WriteLine(c.ToString("MM/dd/yyyy"));
            //Console.WriteLine(c.ToString("yyyy/MM/dd"));
            //Console.WriteLine(c.ToString("hh:mm tt"));
            //Console.WriteLine(c.ToString("HH:mm"));
            //Console.WriteLine(c.ToString("dddd, dd MMM yyyy"));
            //Console.WriteLine("Entr a date");
            //DateTime dt=Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(dt);


            // string s = "123";
            //int num=int.Parse(s);
            //Console.WriteLine(num);

            //int num1=int.Parse(s1);
            //Console.WriteLine(num1);

            //string s2 = null;
            //int num2=int.Parse(s2);
            //Console.WriteLine(num2);
            //Parse cannot handle null, it can only handle valid strings

            //string s2 = null;
            //int num2 = Convert.ToInt32(s2);
            //Console.WriteLine(num2);

            //Tryparse no exception thrown, parse throws exception if input is invalid
            //Tryparse returns a bool, parse exception
            //Tryparse is safer for userinput, parse is not
            //if (int.TryParse(s, out int numval))
            //{
            //    Console.WriteLine(numval);

            //}
            //else
            //    Console.WriteLine("Invalid Input");



            //object o = new DateTime(2025, 1, 1);
            //Inherits from object
            //object obj;//Base of all datatype. All datatypes inherit from object
            ////string s = "Hello";
            ////obj = s;====Not allowed
            //int i = 10000;
            ////Value(struct or enum) types of data
            //obj = i;   //Boxing ----Only value types can be boxed

            //int j =(int)obj;//Unboxing---- it involves casting, ie converting it to its original type


            //obj.ToString();
            //obj.Equals();
            //obj.GetType();
            //obj.GetHashCode();

            //string s1 = "Hello";
            //string s2 = "Hello";


            ////if (s1.Equals(s2))
            //if (s1 == s2)
            //{
            //    Console.WriteLine("They are  same");
            //}
            //else
            //{

            //    Console.WriteLine("Not same");
            //}

            //float i = 100;
            //float f1 = 100.00f;
            //if (i.Equals(f1))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("Not same");
            //}


            //object o1 = 100;
            //int i = 100;
            //if (o1.Equals(i))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("Not Same");
            //}


            //string s = "H";
            //char s1 = 'H';
            //if (s.Equals(s1.ToString()))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("Not same");
            //}

            //int val = 1000;
            //Console.WriteLine($"DataType of val={val.GetType()}");
            //Console.WriteLine($"DataType of val={val.ToString().GetType()}");


            string name = "John";
            int rno = name.GetHashCode();
            Console.WriteLine(rno);
            string name1 = "John";
            int rno1 = name.GetHashCode();
            Console.WriteLine(rno1);
            //Console.WriteLine(name.GetHashCode());//random number
            //float i = 100.0455f;
            //Console.WriteLine(i.GetHashCode());//random number
            //bool ans = true;
            //Console.WriteLine(ans.GetHashCode());//1 or 0
            //int i1 = 11;
            //Console.WriteLine(i1.GetHashCode());
            //DateTime dt=DateTime.Now;
            //Console.WriteLine(dt.GetHashCode());




























            //            string fname = "John", lname = "Garard";
            //            string fullname = string.Concat(fname, lname);
            //            //Console.WriteLine($"{fname} {lname}");
            //            Console.WriteLine($"{fullname}");

            //            int qty = 10;
            //            int price = 100;
            //            int total = qty * price;
            //            Console.WriteLine($"TotalPrice={total:C}");//C is currency
            //            float value = 12345.671f;

            //            Console.WriteLine($"Print Till 2 digits= {value:N2}");
            //            Console.WriteLine("===========Using Verbatim character with interpolation=================");



            //            string prodname = "Tea";
            //            float prodprice = 10.00f;

            //            string fulldata = $@"
            //            ProductName:{prodname}
            //            ProductPrice: {prodprice}
            //            ProductCategory: Beverage";

            //            Console.WriteLine(fulldata);

            //            Console.WriteLine("=========================================");


            //            string foldername = "Documents";
            //            string filanme = "demofile.pdf";
            //            string fullpath = $@"C:\Sulakshana\{foldername}\{filanme}";
            //            Console.WriteLine(fullpath);                



            //            //Console.WriteLine($"The total ={qty*price}");








            //            int fno = 100, sno = 20;
            //Program.Calculations(fno,sno,out int ans1,out int ans2,out int ans3,out int ans4);

            //            Console.WriteLine($"The addition of {fno} and {sno}={ans1}");
            //            Console.WriteLine($"The subtraction of {fno} and {sno}={ans2}");//Interpolation operator to print values
            //                Console.WriteLine("The multiplication of " + fno + "and " + sno + "=" + ans3);//Concat using + operator
            //            Console.WriteLine("The division of {0} and {1}={2}",fno,sno,ans4);//Format specifier, replacement/placeholder
            //                                                                              //method
            //            Console.WriteLine("---------------------");


            //            Program.Add(10, 20, out int addans);
            //            Console.WriteLine(addans);


            ////Console.WriteLine("Enter Your Order Status");
            ////string input=Console.ReadLine();//Value comes into input variable

            //////TryPArse methods takes 3 paramters
            //////1) User Input====> input
            //////2) second parameter---ignore case boolean----true
            //////3) pending===Pending, processing----Processing, shipped---Shipped 
            ////if (Enum.TryParse(input,true, out OrderStatus output))
            ////{
            ////    switch (output)
            ////    {
            ////        case OrderStatus.Pending:
            ////            Console.WriteLine("Order status is pending");
            ////            break;
            ////        case OrderStatus.Processing:
            ////            Console.WriteLine("Under Process");
            ////            break;
            ////        case OrderStatus.Shipped:
            ////            Console.WriteLine("Its Shipped");
            ////            break;
            ////        case OrderStatus.Delivered:
            ////            Console.WriteLine("Delivered");
            ////            break;
            ////        case OrderStatus.Cancelled:
            ////            Console.WriteLine("ORder Cancelled");
            ////            break;
            ////        default:
            ////            Console.WriteLine("Invalid input");
            ////            break;
            ////    }

            ////}



            //WeekDays today = WeekDays.Tuesday;

            //switch (today)
            //{
            //    case WeekDays.Monday:
            //        Console.WriteLine("Its Monday");
            //        break;
            //    case WeekDays.Tuesday:
            //        Console.WriteLine("Its Tuesday");
            //        break;
            //    case WeekDays.Wednesday:
            //        Console.WriteLine("Its Wednesday");
            //        break;
            //    case WeekDays.Thursday:
            //        break;
            //    case WeekDays.Friday:
            //        break;
            //    case WeekDays.Saturday:
            //        break;
            //    case WeekDays.Sunday:
            //        break;
            //    default:
            //        break;
            //}




            //Ctrl+K+C-------> Comment
            //Ctrl+K+U-------> UnComment


            //WriteLine is a method  under Console Class
            //Console Class is defined under Base Class Library called System.

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Blue;

            //Console.WriteLine("Hello World");
            //Int32 i = 100;
            //Console.WriteLine(i);
            //int j = 200;
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);



            //long, double,bool,
            //ulong p = 5555555;

            //Console.WriteLine($"Min Value= {ulong.MinValue}");
            //Console.WriteLine($"Max Value= {ulong.MaxValue}");

            ////Specific datatype name to C# is float for Single
            //const float pi = 3.14f;
            // Console.WriteLine(pi);
            // Console.WriteLine(float.MinValue);
            // Console.WriteLine(float.MaxValue);

            // string s = "Hello";
            // Console.WriteLine(s);
            // char c = 'A'; 
            // Console.WriteLine(c);
            // Console.ResetColor();

            // Console.WriteLine("Hello once again......");

            //FrameworkDefined
            //  Single piVar = 3.14f;



        }
    }
}
