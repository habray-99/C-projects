using System;
namespace poly
{
    public class Person
    {
        public string? FullName;
        public string? PhoneNumber;
        public void PrintFullName(){
          Console.WriteLine($"My name is {FullName}", ConsoleColor.Green);
        }
        public virtual void PrintDetail(){
         Console.WriteLine("General Instruction");
        }
    }
    public class Student:Person
    {
        public override void PrintDetail(){
         Console.WriteLine($"Hi! My name is {FullName} and i am a Student of icp");
        }
    }
 
