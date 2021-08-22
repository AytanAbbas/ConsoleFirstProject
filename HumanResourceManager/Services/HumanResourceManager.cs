using System;
using HumanResourceManagment.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourceManagment.Models;

namespace HumanResourceManagment.Services
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
        }                           //Create department and add department to Departments list
        
        public void AddEmployee(Employee employee, string DepartmentName)
        {
            _employee.Add(employee);
        }         //Create employee and add employee to Employees list

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

        }                //Change on the department

        public List<Department> GetDepartments()
        {
            return _departments;
        }                                //Returns all departments in the system

        public void RemoveEmployee(string employeeno, string departmentName)
        {
            var EmployeeList = _employee.ToList();
            var RemoveItem = _employee.Find(e => e.No.ToLower() == employeeno.ToLower() && e.DepartmentName.ToLower() == departmentName.ToLower());
            _employee.Remove(RemoveItem);

        }   //dDlete the numbered employee from the employee list

        public Department FindDepartmentByName(string name)

        { foreach (var item in _departments)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
               return null;
        }                   //Finding according to the name of the department

        public List<Employee> EditEmployee(string no, string fullName, double salary, string position)
        {
            return _employee.FindAll(e => e.No.ToLower() == no.ToLower() && e.FullName.ToLower() == fullName.ToLower() && e.Salary == salary && e.Position.ToLower() == position.ToLower());
        }   //Change on the employee


    }

}
