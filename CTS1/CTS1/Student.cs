using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS1
{
    class Student
    {
        public Student(string firstName, string middleName, string lastName, string ssn, string address,
            string phone, string email, string course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
        }



        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public override bool Equals(object obj)
        {
            Student s1 = obj as Student;
            if (s1 == null)
                return false;

            if (!Object.Equals(this.FirstName, s1.FirstName))
                return false;

            if (this.SSN != s1.SSN)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public static bool operator == (Student s1, Student s2)
        {
            return Student.Equals(s1, s2);
        }

        public static bool operator != (Student s1, Student s2)
        {
            return !(Student.Equals(s1, s2));
        }

        public override string ToString()
        {
            return "Student " + FirstName + " with the SSN: " + SSN;
        }
    }
}
