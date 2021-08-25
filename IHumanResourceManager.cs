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
         void AddEmployee(Employee employee, string DepartmentName);
         void RemoveEmployee();
         void EditEmployee();

    }
}
