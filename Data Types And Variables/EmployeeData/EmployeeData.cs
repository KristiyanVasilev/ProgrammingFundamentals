﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            short age = 27;
            char gender = 'f';
            long personalID = 8306112507L;
            int employeeNumber = 27563571;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Lirst name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}