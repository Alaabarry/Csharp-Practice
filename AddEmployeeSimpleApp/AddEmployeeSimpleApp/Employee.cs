﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{ 
    // create class employee the inherit from person class
    public  class Employee : Person
    {  
        //create propertie of integer that takes employee id...
        public int Id { get; set; }
        //override abstract method add implement to method in employee class 
        public override void AddEmp()
        {
            Console.WriteLine("Employee Full name is " + firstName + lastName);
        }
    }


}