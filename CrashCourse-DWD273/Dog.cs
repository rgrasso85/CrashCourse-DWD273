using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    public class Dog : Animal
    {

        public override string MakeNoise()
        {
            return "Woof!";
        }
        public override string Describe()
        {
            return "This dogs name is " + Name + " and it is " + Age + " year(s) old!";
        }
    }
}
