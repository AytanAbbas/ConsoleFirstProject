using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManager.Models
{
    class Employee
    {
        public Employee(string position) 
        {
            Counter++;
            No = DepartmentName.Substring(0, 2).ToUpper() + Counter;

            position = Position;

        }
        private static int Counter = 1000;
        public string No { get; set; }
        public string FullName { get; set; }
        private double _salary;
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
        private string _position;
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
            foreach (char item in position) 
            {
                if (!Char.IsLetter(item)) 
                {
                    return false;
                }
            }
            return true;
        }
        public string DepartmentName { get; set; }
        public override string ToString()
        {
            return $"No: {No} FullName: {FullName} Position: {Position}  Salary: {Salary} DepartmentName: { DepartmentName}";
        }
    }
}
