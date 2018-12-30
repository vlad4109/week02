using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog : Animal, ISoundInterface
    {
        public Dog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Ham-Ham");
        }
    }
}
