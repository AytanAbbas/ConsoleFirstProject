using HumanResourceManager.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace HumanResourceManager.Interfaces
{
    interface IHumanResourceManager
    {
         List<Department> Departments { get; }
         void AddDepartment (Department department);
         List<Department> GetDepartments();

         void EditDepartaments(string Name, string newName );
         void AddEmployee(Employee employee, string departmentName);
         void RemoveEmployee(int no, string departmentName);
         void EditEmployee(int no, string fullName, double salary, string position);

    }
}
