using System;
using HumanResourceManager.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourceManager.Models;


namespace HumanResourceManager.Services
{
     class HumanResourceManagerr : IHumanResourceManager
    {
        
        private List<Department> _departments;
        public List<Department> Departments => _departments; 

        public HumanResourceManagerr() 
        {
            _departments = new List<Department>();     
        }

        public void ShowDepartments()
        {
              Console.WriteLine("\n=============Departamentler==================");
            
            foreach (Department item in _departments)
            {
               Console.WriteLine($"Name: {item.Name} - Isci sayi: {item.WorkerLimit} - Maas ortalamasi: {item.SalaryLimit}");
                 
            }
            Console.WriteLine("===============================\n");
        }

        public void ShowAllEmpoyees()
        {
            Console.WriteLine("====Employees====");
            foreach (Department  item in _departments)
            {
                foreach (Employee employee in item.Employees)
                {
                     Console.WriteLine($"Ishcinin nomresi:{employee.No} - Ad soyad: {employee.FullName} - Department adi: {employee.DepartmentName}- Ishcinin maashi: {employee.Salary}");
                }
            }

        }
        public void ShowEmployeesOfADepartment()
        {
            {
                Console.WriteLine("Departament adi daxil edin:");
                string name = Console.ReadLine();
                Department department = _departments.Find(d => d.Name.ToLower() == name.ToLower());
                var count = 0;
                while (department==null)
                {
                    Console.WriteLine("Bele bir department movcud deyil !");
                    name = Console.ReadLine();
                }
                          
                    foreach (Employee employee in department.Employees)
                    {
                    Console.WriteLine(count+". ");
                    Console.WriteLine(employee.FullName);
                        Console.WriteLine(employee.Position);
                        Console.WriteLine(employee.No);
                        Console.WriteLine(employee.Salary);
                    count++;
                    }
              
            }
        }
        public void AddDepartment()
        {
            Console.WriteLine("Departamentin Adini Daxil Et");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Departamentin Iscilerinin Sayini Daxil Et");
            string limit = Console.ReadLine();
            int workerLimit;
            while (!int.TryParse(limit, out workerLimit))
            {
                Console.WriteLine("Iscilerin Sayini Duzgun Daxil Et");
                limit = Console.ReadLine();
                int.TryParse(limit, out workerLimit);
            }
            Console.WriteLine("Departamentin Iscilerinin Ayliq Emek haqqini Daxil Et");
            string salary = Console.ReadLine();
            double salaryLimit;
            while (!double.TryParse(salary, out salaryLimit))
            {
                Console.WriteLine("Departamentin Iscilerinin Ayliq Emek haqqini Duzgun Daxil Et");
                salary = Console.ReadLine();
                double.TryParse(salary, out salaryLimit);
            }
            Department dep = new Department(departmentName, workerLimit, salaryLimit, new List<Employee>());
            _departments.Add(dep);
            Console.WriteLine(_departments);
        }
        
        public void AddEmployee()
        {
            Console.WriteLine(" Yeni Ishcinin Departament Adini Daxil Et");
            string depName = Console.ReadLine();
            Department department = _departments.Find(d => d.Name.ToLower() == depName.ToLower()); 
            while (department == null)
            {
                Console.WriteLine("Bele bir department movcud deyil !");
                depName = Console.ReadLine();
            }

                       //Full name
            Console.WriteLine("Yeni ishci Melumatlari Daxil edilsin");
            string fullName = Console.ReadLine(); 
            Console.WriteLine();

            //position
            Console.WriteLine("Yeni ishci Vezifesi Daxil Et");
            string position = Console.ReadLine(); 
            Console.WriteLine();

            //salary
                    Console.WriteLine("Yeni Ishcinin Maashini  Daxil Et");
            double salary;
            string inputSalary = Console.ReadLine();
            while (!double.TryParse(inputSalary, out salary))
            {
                Console.WriteLine("Reqem daxil et");
                inputSalary = Console.ReadLine();
            } 

            Employee newEmployee = new Employee(fullName, depName,position,salary);
            department.Employees.Add(newEmployee);
            Console.WriteLine(department.Employees);
        }

        public void EditDepartaments( )
        {
            Console.WriteLine("Duzelis Etmek Isdediyniz Departamentin Adini Daxil Et");
            string name = Console.ReadLine();
            int departmentName;
            Department Dep = _departments.Find(d => d.Name.ToLower() == name.ToLower());
            Console.WriteLine(Dep);
            while (Dep == null)
            {
                Console.WriteLine("Duzelis Etmek Isdediyniz Departamentin Adini Duzgun Daxil Et");
                name = Console.ReadLine();
                int.TryParse(name, out departmentName);
            }

            Department department = FindDepartmentByName(name);
            if (department == null)
            {
                Console.WriteLine($"{name} adli department movcud deyil!");
                return;
            }
            else 
            {
                if (FindDepartmentByName(name) != null) 
                {
                    Console.WriteLine($"{name} adli department movcuddur!");

                    //Editting Department

                    //Worker limit
                    Console.WriteLine("Departamentin Iscilerinin Sayini Daxil Et");
                    string limit = Console.ReadLine();
                    int workerLimit;
                    while (!int.TryParse(limit, out workerLimit))
                    {
                        Console.WriteLine("Iscilerin Sayini Duzgun Daxil Et");
                        limit = Console.ReadLine();
                        int.TryParse(limit, out workerLimit);
                    }
                    //Salary limit
                    Console.WriteLine("Departamentin Iscilerinin Ayliq Emek haqqini Daxil Et");
                    string salary = Console.ReadLine();
                    double salaryLimit;
                    while (!double.TryParse(salary, out salaryLimit))
                    {
                        Console.WriteLine("Departamentin Iscilerinin Ayliq Emek haqqini Duzgun Daxil Et");
                        salary = Console.ReadLine();
                        double.TryParse(salary, out salaryLimit);
                    }

                    Dep.WorkerLimit = workerLimit;
                    Dep.SalaryLimit = salaryLimit;
                    return;
                }
            }

        }

        public List<Department> GetDepartments()
        {
            return _departments;
        }

        public void RemoveEmployee()
        {
            Console.WriteLine("Silmek Istediyiniz Ishcinin Nomresini Daxil Edin");
            string no = Console.ReadLine();
            Console.WriteLine("Silmek Istediyinviz Ishcinin Departmentinin Adini Daxil Edin");
                        string departmentNamee = Console.ReadLine();
            var dep = _departments.Find(d => d.Name.ToLower() == departmentNamee.ToLower());
            var employee = dep.Employees.Find(em => em.No.ToLower() == no.ToLower());

            dep.Employees.Remove(employee);

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
         
        public void AddEmployee(Employee employee, string DepartmentName)
        {
            throw new NotImplementedException();
        }

        public void AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments(string Name, string newName)
        {
            throw new NotImplementedException();
        }
        
      public  void EditEmployee()
        {
            //Console.WriteLine("Ishcinin adini daxil edin:");
            //string employeeName = Console.ReadLine();
            //List<Employee> employees = new List<Employee>();
            //foreach (Department item in _departments)
            //{
            //    foreach (Employee employee in item.Employees)
            //    {
            //        employees.Add(employee);
            //    }
            //}
            //Employee em = employees.Find(e => e.FullName.ToLower() == employeeName.ToLower());
            //while (em == null)
            //{
            //    Console.WriteLine("Bele bir ishci movcud deyil !");
            //    employeeName = Console.ReadLine();
            //}

            //Console.WriteLine("Duzelish olunacaq Iscinin Nomresini Daxil Et");
            //string no = Console.ReadLine(); 
              
            

            //if (no.ToLower() == em.No.ToLower())
            //{
            //    Console.WriteLine("Iscinin Yeni adini  Daxil Et");
            //    string newName= Console.ReadLine();
            //    Console.WriteLine("Iscinin Yeni Vezifesini Daxil Et");
            //    string newPosition = Console.ReadLine();
            //    Console.WriteLine();

            //    Console.WriteLine("Iscinin Yeni Maashini Daxil Et");
            //    double NewSalary;
            //    string NewSalaryInput = Console.ReadLine();
            //    Console.WriteLine();
            //    while (!double.TryParse(NewSalaryInput, out NewSalary))
            //    {

            //        Console.WriteLine();
            //        Console.WriteLine("Reqem daxil edilmelidir!");
            //        NewSalaryInput = Console.ReadLine();
            //        Console.WriteLine();
            //    }

           
            //    foreach (Department item in _departments)
            //    {
            //        foreach (Employee employee in item.Employees)
            //        {
            //            if (employee.No.ToLower() ==no.ToLower())
            //            {
            //                Employee e = new Employee(newName, item.Name, newPosition, NewSalary);
            //                e.No = no;
            //                item.Employees.Add(e);
            //                item.Employees.Remove(employee);
            //            } 
            //        }
            //    }
            //    Console.WriteLine(_departments);
            //}
            //else
            //{
            //    Console.WriteLine("Axtarishiniza Uygun Ishci Yoxdur");
            //}
        }

  
    }

}
