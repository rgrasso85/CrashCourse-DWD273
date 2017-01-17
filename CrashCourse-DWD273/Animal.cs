using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    //abstract doesnt allow instances of parent, only child
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }


        //Allows this string to be overridden by child class
        public virtual string MakeNoise()
        {
            return "noise";
        }
        public virtual string Describe()
        {
            return "Animal Description";
        }

    }
}
