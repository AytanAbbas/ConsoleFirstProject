using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManager.Models
{
    class Department
    {  
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

            }
        }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        private List<Employee> Employees;

        public int CalcSalaryAvarage(int salary) 
        {   

            return 0;
        }
    }
    
}
