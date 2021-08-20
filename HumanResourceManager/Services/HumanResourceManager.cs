using System;
using HumanResourceManager.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourceManager.Models;

namespace HumanResourceManager.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public Department[] Departments => throw new NotImplementedException();

        public void AddDepartment(string Name, int WorkerLimit, int SalaryLimit)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(string No, string FullName, double Salary, string Position, string DepartmentName)
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments(string Name, string newName)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(string No, string FullName, double Salary, string Position)
        {
            throw new NotImplementedException();
        }

        public void GetDepartments(Department Departaments)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(string No, string Name)
        {
            throw new NotImplementedException();
        }
    }

}
