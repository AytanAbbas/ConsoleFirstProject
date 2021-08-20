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
        public List<Department> Departments => throw new NotImplementedException();

        public void AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee, string departmentName)
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments(string Name, string newName)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(int no, string fullName, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int no, string departmentName)
        {
            throw new NotImplementedException();
        }
    }

}
