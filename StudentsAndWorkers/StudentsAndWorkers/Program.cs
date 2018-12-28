using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        public static void PrintAllTheStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Student {student.FirstName} {student.LastName} has a grade of: {student.Grade}!");
            }
        }


        public static void PrintAllTheWorkers(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"Worker {worker.FirstName} {worker.LastName} has a week salary of {worker.WeekSalary}$, and works {worker.WorkHoursPerDay} hours per day, meaning he is paid with {worker.MoneyPerHour()}$ per hour!");
            }
        }

        public static void PrintAllTheHumans(List<Human> humans)
        {
            foreach (Human human in humans)
            {
                Console.WriteLine($"Human {human.FirstName} {human.LastName}.");
            }
        }

        static void Main(string[] args)
        {


            List<Worker> workersList = new List<Worker>();
            Worker w1 = new Worker("George", "Peterson", 280, 10);
            workersList.Add(w1);
            Worker w2 = new Worker("John", "Hamilton", 310, 12);
            workersList.Add(w2);
            Worker w3 = new Worker("Dave", "Maynard", 290, 11);
            workersList.Add(w3);
            Worker w4 = new Worker("Lloyd", "Mathinson", 310, 12);
            workersList.Add(w4);
            Worker w5 = new Worker("Gary", "Robinson", 400, 13);
            workersList.Add(w5);
            Worker w6 = new Worker("Douglas", "Harbin", 330, 12);
            workersList.Add(w6);
            Worker w7 = new Worker("Kenneth", "Hart", 320, 11);
            workersList.Add(w7);
            Worker w8 = new Worker("Denis", "Remy", 310, 11);
            workersList.Add(w8);
            Worker w9 = new Worker("Ken", "Copeland", 300, 11);
            workersList.Add(w9);
            Worker w10 = new Worker("Marilyn", "Chambers", 300, 10);
            workersList.Add(w10);


            List<Student> studentsList = new List<Student>();
            Student s1 = new Student("William", "Matthers", 8);
            studentsList.Add(s1);
            Student s2 = new Student("Dan", "Smith", 7);
            studentsList.Add(s2);
            Student s3 = new Student("Rebecca", "Crowley", 9);
            studentsList.Add(s3);
            Student s4 = new Student("Keith", "Workman", 10);
            studentsList.Add(s4);
            Student s5 = new Student("Adrianna", "Avila", 6);
            studentsList.Add(s5);
            Student s6 = new Student("Carl", "Rayburn", 5);
            studentsList.Add(s6);
            Student s7 = new Student("Roger", "Le", 7);
            studentsList.Add(s7);
            Student s8 = new Student("Marvin", "Daniels", 9);
            studentsList.Add(s8);
            Student s9 = new Student("George", "Moore", 10);
            studentsList.Add(s9);
            Student s10 = new Student("Anne", "Delaney", 8);
            studentsList.Add(s10);

            Console.WriteLine("The students are the following:");
            PrintAllTheStudents(studentsList);
            Console.WriteLine();

            Console.WriteLine("The workers are the following:");
            PrintAllTheWorkers(workersList);
            Console.WriteLine();

            Console.WriteLine("The list of the students ordered ascending by their grades is:");
            List<Student> orderedStudentsList = studentsList.OrderBy(student => student.Grade).ToList();
            PrintAllTheStudents(orderedStudentsList);
            Console.WriteLine();

            Console.WriteLine("The list of the workers ordered descending by their income per hour is:");
            List<Worker> orderedWorkersList = workersList.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            PrintAllTheWorkers(orderedWorkersList);
            Console.WriteLine();

            Console.WriteLine("The list of the students and the list of the workers merged is:");
            List<Human> humansList = studentsList.Cast<Human>().Concat(workersList).ToList();
            PrintAllTheHumans(humansList);
            Console.WriteLine();

            Console.WriteLine("The list of the students and the list of the workers merged and sorted by name is:");
            List<Human> orderedHumansList = humansList.OrderBy(human => human.FirstName).ToList();
            PrintAllTheHumans(orderedHumansList);
            Console.WriteLine();
        }
    }
}