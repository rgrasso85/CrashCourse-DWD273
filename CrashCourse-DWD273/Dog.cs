using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    public class Dog
    {
        // Attributes / Properties
        public int Age { get; set; }
        public string Name { get; set; }
        // Constructor
        public Dog(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        // Methods

        public string Walk()
        {
            return "Walking...";
        }

        public string MakeNoise()
        {
            return "Woof!";
        }

        public string Describe()
        {
            return "This dogs name is " + this.Name + " and it is " + this.Age + " year(s) old!";
        }
    }
}
