using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Person
    {
        protected String FullName;
        protected String PhoneNumber;

        //protected Person(string fullName, string phoneNumber)
        //{
        //    FullName = fullName;
        //    PhoneNumber = phoneNumber;
        //}

        public abstract void PrintDetail();
    }
    public class Student : Person
    {
        private int _semester;

        public Student(string name, string phoneNumber, int _sem)
        {
            FullName = name;
            PhoneNumber = phoneNumber;
            _semester = _sem;
        }

        public override void PrintDetail()
        {
            Console.WriteLine($"Hi! My name is {FullName} and i read in {_semester} semester");
            Console.WriteLine($"My phone number is {PhoneNumber}");
        }
    }
}
