using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS1
{
    class Program
    {
        public enum Specialty
        {
            Maths,
            Informatics,
            Physics,
            Chemistry
        };

        public enum University
        {
            Hogwarts,
            Greenwich,
            Harvard
        };

        public enum Faculty
        {
            AutomaticsAndCalculators,
            Economics,
            Ingineering
        };

        public static void Print(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Student {student.FirstName} {student.MiddleName} {student.LastName}" +
                    $" having the SSN: {student.SSN}, living on the {student.Address} street, with" +
                    $" the phone number: {student.Phone}, email: {student.Email} has now the course: " +
                    $"{student.Course}");
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("George", "William", "Washington", "123456789", "Steven the Great, nr 20",
                "0745 634 551", "george_w87@yahoo.com", "Applied Mathematics");
            students.Add(s1);
            Student s2 = new Student("George", "William", "Washington", "987654321", "Steven the Great, nr 20",
                "0745 634 432", "george_w_w87@yahoo.com", "Applied Mathematics");
            students.Add(s2);
            Print(students);

            Specialty specialties = Specialty.Maths;
            Faculty faculties = Faculty.Ingineering;
            University universities = University.Harvard;

            Console.WriteLine($"\nStudent {s1.FirstName} {s1.MiddleName} {s1.LastName} goes to the " +
                $"{faculties} Faculty from the {universities} University at the {specialties} specialty!\n");
            
            bool equal = System.Object.Equals(s1, s2);
            Console.WriteLine("Student1 and Student2 {0} equals", equal ? "are" : "are not");


            Console.WriteLine(s1);
           
            if(s1==s2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
