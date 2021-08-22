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
        
        private List<Department> _departments;
        public List<Department> Departments => _departments;
        private List<Employee> _employee;
        public List<Employee> Employees => _employee;

        public HumanResourceManager() 
        {
            _departments = new List<Department>();
            _employee = new List<Employee>();      
        }

        public void AddDepartment(Department department)
        {
            _departments.Add(department);
        }
        
        public void AddEmployee(Employee employee, string DepartmentName)
        {
            _employee.Add(employee);
        }

        public void EditDepartaments(string name, string newname)
        {
            Department department = FindDepartmentByName(name);
            if (department == null)
            {
                Console.WriteLine("{Name} adli department movcud deyil!");
                return;
            }
            else 
            {
                if (FindDepartmentByName(newname) != null) 
                {
                    Console.WriteLine($"{newname} adli department movcuddur!");
                    return;
                }
            }

        }

        public List<Department> GetDepartments()
        {
            return _departments;
        }

        public void RemoveEmployee(string employeeno, string departmentName)
        {
            var EmployeeList = _employee.ToList();
            var RemoveItem = _employee.Find(e => e.No.ToLower() == employeeno.ToLower() && e.DepartmentName.ToLower() == departmentName.ToLower());
            _employee.Remove(RemoveItem);

        }

        public Department FindDepartmentByName(string name)

        { foreach (var item in _departments)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
               return null;
        }

        public List<Employee> EditEmployee(string no, string fullName, double salary, string position)
        {
            return _employee.FindAll(e => e.No.ToLower() == no.ToLower() && e.FullName.ToLower() == fullName.ToLower() && e.Salary == salary && e.Position.ToLower() == position.ToLower());
        }
    }

}
