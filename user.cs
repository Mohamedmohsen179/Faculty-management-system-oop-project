using System;
using System.Collections.Generic;

namespace oop_project
{
    public abstract class Human
    {
        protected string Name;
        protected int PhoneNum;
        protected string Email;
        protected int Id ;



        public void Set_name (string name)
        {
               Name = name;
        }
        public void Set_phoneNum (int phoneNum)
        {
            PhoneNum = phoneNum;
        }
        public void Set_Email(string email)
        {
            Email = email;
        }
        public void Set_id(int id)
        {
            Id = id;
        }
        public int Get_id()
        {
            return Id;
        }
        public abstract void printDetails();
           
    }

    internal class Student : Human
    {
        int Level;
        float Gpa;

        public void Set_level(int level)
        {
            Level = level;
        }
        public void Set_gpa(float gpa)
        {
            Gpa = gpa;
        }

        

        public override void printDetails()
        {
            Console.WriteLine($"Name is : {Name}");
            Console.WriteLine($"PhoneNum is : {PhoneNum}");
            Console.WriteLine($"Id is : {Id}");
            Console.WriteLine($"Email is : {Email}");
            Console.WriteLine($"level is : {Level}");
            Console.WriteLine($"Gpa is : {Gpa}" );

        }


    }
    public class Doctor : Human
    {
        List<string> courses = new List<string>();

        public void Set_courses(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter Course number {i + 1}: ");
                string course = Console.ReadLine();
                courses.Add(course);
            }
        }

        public override void printDetails()
        {
            Console.WriteLine($"Name is : {Name}");
            Console.WriteLine($"PhoneNum is : {PhoneNum}");
            Console.WriteLine($"Id is : {Id}");
            Console.WriteLine($"Email is : {Email}");
            Console.Write("Courses are : ");
            Console.Write('[');
            foreach (var course in courses)
            {
                Console.Write($" {course}, ");
            }
            Console.Write(" ]\n");
        }
    }

    internal class Employ : Human
    {
        protected string Role;

        public void Set_role(string role)
        {
            Role = role;

        }
        public override void printDetails()
        {
            Console.WriteLine($"Name is : {Name}");
            Console.WriteLine($"PhoneNum is : {PhoneNum}");
            Console.WriteLine($"Id is : {Id}" );
            Console.WriteLine($"Email is : {Email}");
            Console.WriteLine($"role is : {Role}");

        }
    }
}
