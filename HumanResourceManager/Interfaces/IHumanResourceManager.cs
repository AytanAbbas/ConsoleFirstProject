using HumanResourceManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManager.Interfaces
{
    interface IHumanResourceManager
    {
         Department[] Departments { get; }
          void AddDepartment(string Name, int WorkerLimit, int SalaryLimit);
        void GetDepartments(Department Departaments);
      
        void EditDepartaments(string Name, string newName );
        void AddEmployee(string No, string FullName, double Salary, string Position, string DepartmentName);
        void RemoveEmployee(string No, string Name);
        void EditEmployee(string No, string FullName, double Salary, string Position);

    }
}
