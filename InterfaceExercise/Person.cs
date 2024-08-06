using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Person : IPerson
    {
        private string FirstName;
        private string LastName;
        private DateTime BirthDate; 

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string GetFullName()
        {
            return FirstName+" "+LastName;
        }

        public int GetAge() 
        {
            { return CalculateAge(); }
        }
        // exercise 2.1
        private int CalculateAge()
        { return DateTime.Now.Year - BirthDate.Year; }

    }

    public class Student : Person, IJob
    {
        public Student(string firstName, string lastName, DateTime birthDate):base(firstName,lastName,birthDate)  { }

        public string GetRole()
        {
            return GenerateRole(); 
        }
        private readonly string Role = "Student";
        // exercise 2.2
        private string GenerateRole()
        {
            return Role;
        }
    }
    public class Teacher : Person, IJob
    {
        public Teacher(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate) { }

        public string GetRole()
        {
            return GenerateRole();
        }
        private readonly string Role = "Teacher";

        // exercise 2.2
        private string GenerateRole()
        {
            return Role;
        }
    }
    class Program
    {
        static void Main()
        {
            Student student = new Student("John", "Doe", new DateTime(2020, 5, 10));
            Console.WriteLine(student.GetFullName());
            Console.WriteLine(student.GetAge());
            Console.WriteLine(student.GetRole());

            Teacher teacher = new Teacher("f", "l", new DateTime(2020, 9, 11));
            Console.WriteLine(teacher.GetFullName());
            Console.WriteLine(teacher.GetAge());
            Console.WriteLine(teacher.GetRole());
        }
    }
}
