﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int intTest = 1;
            double doubleTest = 1.1;
            bool booleanTest = true;
            char charTest = 'A';
            string stringTest = "This is a String.";
            Console.WriteLine("intTest = " + intTest + "\ndoubleTest = " + doubleTest + "\nbooleanTest = " + booleanTest + 
                "\ncharTest = " + charTest + "\nstringTest = " + stringTest);
            string data = Console.ReadLine();
        }
    }
}
