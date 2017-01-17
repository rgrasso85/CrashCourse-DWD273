using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    public class Cat : Animal
    {

        public override string MakeNoise()
        {
            return "Meow!";
        }
        public override string Describe()
        {
            return "This cats name is " + Name + " and it is " + Age + " year(s) old!";
        }
    }
}
