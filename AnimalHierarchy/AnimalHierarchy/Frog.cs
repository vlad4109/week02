using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal, ISoundInterface
    {
        public Frog(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Ribbit");
        }
    }
}
