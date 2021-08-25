using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManager.Models
{
    class Employee
    {
        
        private static int Counter = 1000; 
        private string _position;
        private double _salary;

        public string No { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }

        public double Salary 
        {
            get 
            {
                return _salary;
            } 
            set 
            {
                if (value > 250)
                {
                    _salary = value;
                }
                else 
                {
                    Console.WriteLine("Ishcinin maashi 250-den ashagi ola bilmez");
                }
            } 
        }
        public string Position {
            get
            {
                return _position;
            } 
            set 
            {
                if (checkPosition (value)) 
                {
                    _position = value;
                }
                else
                {
                    Console.WriteLine("Minimum 2 herfden ibaret olmalidir ");
                }
            } 

        }
        private bool checkPosition(string position ) 
        { if (position.Length < 2) 
            {
                return false;
            }
            else
            {

            foreach (char item in position) 
            {
                if (!Char.IsLetter(item)) 
                {
                    return false;
                }
            }
            return true;
            }
        }

        public Employee(string fullName,string departmentName, string position ,double salary)
        {
            Counter++;
            this.DepartmentName = departmentName;
            this.No = departmentName.Substring(0, 2).ToUpper() + Counter;
            this.Position = position;
            this.Salary = salary;
            this.FullName = fullName;

        }


        public override string ToString()
        {
            return $"No: {No} \nFullName: {FullName} \nPosition: {Position}  \nSalary: {Salary} \nDepartmentName: { DepartmentName}";
        }
    }
}
