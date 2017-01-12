using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    class Car
    {
        // Attributes / Properties
        public string color { get; set; }
        // Constructor
        public Car(string color)
        {
            this.color = color;
        }
        // Methods
        public string Describe()
        {
            return "This car is " + this.color + ".";
        }

        public string Drive()
        {
            return "Driving...";
        }
    }
}
