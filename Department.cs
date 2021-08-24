﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagment.Models
{
    class Department
    {  
        private string _name;
        private int _workerLimit;
        private double _salaryLimit;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (checkName(value))
                {
                    _name = value;
                }
                else 
                {
                    Console.WriteLine( "Departamentin adi sehvdir");
                }
            }

        }
        private bool checkName(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            //foreach (char item in name)
            //{
            //    if (!Char.IsLetter(item))
            //    {
            //        return false;
            //    }
            //    else 
            //    {
                   
            //    }
            //}
            return true;
        }
        
        public int WorkerLimit 
        {
            get 
            {
                return _workerLimit;
            }
            set
            {
                if (value > 1) 
                {
                    _workerLimit = value;
                }
                else
                {
                    Console.WriteLine("Minimum 1 ola biler");
                }
            }
            
        }
       
        public double SalaryLimit
        { get 
           {
                return _salaryLimit;
           }
            set
            {
                if (value > 250)
                {
                    _salaryLimit = value;
                }
                else
                {
                    Console.WriteLine("Ishcinin maashi 250-den ashagi ola bilmez");
                }
            }
        }
        
        public List<Employee> Employees { get; set; }
         

        public double CalcSalaryAvarage( )
        {
            double result = 0;
            double SalaryAvarage = 0;
            foreach (Employee employee in Employees)
            {
                result += employee.Salary;
            }
            if (Employees.Count > 0)
            {
                SalaryAvarage = result / Employees.Count;
            }
            else 
            {
                return 0;
            }
            return SalaryAvarage;
        } 
    }
    
}
