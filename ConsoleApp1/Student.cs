using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsContd
{
    public class Student
    {

        static int rollno = 0;//static remembers previous values

        
        public void NewStudent()
        {
            Console.WriteLine("Enter Name");
            string studname=Console.ReadLine();

            Console.WriteLine("Enter Birth date");

            DateTime birthdate = new DateTime();
            birthdate=Convert.ToDateTime(Console.ReadLine());

            int age=DateTime.Now.Year - birthdate.Year;
            
            rollno = rollno + 1;
            Console.WriteLine($"Your name {studname} and  Rollno= {rollno}, Age={age}");

        }
    }
}
