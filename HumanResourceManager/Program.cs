using HumanResourceManagment.Models;
using HumanResourceManagment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager humanResourceManager = new HumanResourceManager();
            do
            {
                Console.WriteLine("Seçiminizi edin");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1.1 Departamentlerin siyahısını göster");
                Console.WriteLine("1.2 Yeni departament elave et");
                Console.WriteLine("1.3 Departament üzerinde düzeliş et");
                Console.WriteLine("2.1 İşçilerin siyahısını göster");
                Console.WriteLine("2.2 Departamentdeki işçilerin siyahısını göster");
                Console.WriteLine("2.3 Yeni işçi elave et");
                Console.WriteLine("2.4 İşçi üzerinde düzeliş et");
                Console.WriteLine("2.5 Departamentden işçi sil");
                Console.WriteLine("3- Sistemden çıx");
                Console.WriteLine(Environment.NewLine);
                string ans = Console.ReadLine();

                switch (ans)
                {
                    case "1.1":
                        ShowDepartments(humanResourceManager);
                        break;
                    case "1.2":
                        AddDepartment(humanResourceManager);
                        break;
                    case "1.3":
                        EditDepartment(humanResourceManager);
                        break;
                    case "2.1":
                        ShowAllEmployees(humanResourceManager);
                        break;
                    case "2.2":
                        ShowEmployeesofDepartment(humanResourceManager);
                        break;
                    case "2.3":
                        AddEmployee(humanResourceManager);
                        break;
                    case "2.4":
                        EditEmployee(humanResourceManager);
                        break;
                    case "2.5":
                        RemoveEmployee(humanResourceManager);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Secdiyiniz emeliyyat movcud deyil, tekrar secin!");
                        break;
                }


            } while (true);
        }
        static void ShowDepartments(HumanResourceManager humanResourceManager)
        {
            if (humanResourceManager.Departments.Count > 0)
            {
                Console.WriteLine("\n=============Departamentler==================");
                foreach (var item in humanResourceManager.Departments)
                {
                    Console.WriteLine($"Name: {item.Name} - Isci sayi: {item.WorkerLimit} - Maas ortalamasi: {item.CalcSalaryAvarage()}");
                }
                Console.WriteLine("===============================\n");
            }

        }
        static void AddDepartment(HumanResourceManager humanResourceManager)
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
            Department department = new Department
            {
                Name = departmentName,
                WorkerLimit = workerLimit,
                SalaryLimit = salaryLimit,
            };
            humanResourceManager.AddDepartment(department);
        }
        static void EditDepartment(HumanResourceManager humanResourceManager)
        {     
            Console.WriteLine("Duzelis Etmek Isdediyniz Departamentin Adini Daxil Et");
            string name = Console.ReadLine();
            int departmentName;
            while (!int.TryParse(name, out departmentName))
            {
                Console.WriteLine("Duzelis Etmek Isdediyniz Departamentin Adini Duzgun Daxil Et");
                name = Console.ReadLine();
                int.TryParse(name, out departmentName);
            }
     
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

        }
        static void ShowAllEmployees(HumanResourceManager humanResourceManager)
        {
            if (humanResourceManager.Employees.Count > 0)
            {
              
                foreach (var item in humanResourceManager.Employees)
                {
                    Console.WriteLine($"Ishcinin nomresi:{item.No} - Ad soyad: {item.FullName} - Department adi: {item.DepartmentName}- Ishcinin maashi: {item.Salary}");
                }
            }

        }
        static void ShowEmployeesofDepartment(HumanResourceManager humanResourceManager)
        {
            {
                Console.WriteLine("Departament adi daxil edin:");
                string name = Console.ReadLine();
                foreach (Employee employee in humanResourceManager.Employees)
                {
                    if (name.ToLower() == employee.DepartmentName)
                    {
                        Console.WriteLine(employee.FullName);
                        Console.WriteLine(employee.Position);
                        Console.WriteLine(employee.No);
                        Console.WriteLine(employee.Salary);

                    }
                }
            }
        }
        static void AddEmployee(HumanResourceManager humanResourceManager)
        {
            Employee employee = new Employee();
            Console.WriteLine("Yeni ishci Melumatlari Daxil edilsin");
            string fullName = Console.ReadLine();
            employee.FullName = fullName;
            Console.WriteLine();

            Console.WriteLine("Yeni ishci Vezifesi Daxil Et");
            string position = Console.ReadLine();
            employee.Position = position;
            Console.WriteLine();
                    
            Console.WriteLine("Yeni Ishcinin Maashini  Daxil Et");
            double salary;
            string inputSalary = Console.ReadLine();
            while (!double.TryParse(inputSalary,out salary))     
            {
                Console.WriteLine("Reqem daxil et");
                inputSalary = Console.ReadLine();
            }
            employee.Salary = salary;

            Console.WriteLine("Yeni Ishcinin Departament Adini Daxil Et");
            string departmentName = Console.ReadLine();
            employee.DepartmentName = departmentName;
            Console.WriteLine();


        }
        static void EditEmployee(HumanResourceManager humanResourceManage)
        {
            Employee employee = new Employee();
            Console.WriteLine("Duzelish olunacaq Iscinin Nomresini Daxil Et");
            string no = Console.ReadLine();
            int employeeNo;
            while (!int.TryParse(no, out employeeNo))
            {
                Console.WriteLine("Duzelis Etmek Isdediyniz Iscinin nomresini Duzgun Daxil Et");
                no = Console.ReadLine();
                int.TryParse(no, out employeeNo);
            }

            Console.WriteLine("Iscinin Adini ve Soyadini Daxil Et");
            string fullName = Console.ReadLine();

            Console.WriteLine("Iscinin Vezifesini Daxil Et");
            string position = Console.ReadLine();

            Console.WriteLine("Iscinin Maashini Daxil Et");
            double salary = Convert.ToDouble(Console.ReadLine());

            if (no.ToLower() == employee.No.ToLower() && fullName.ToLower() == employee.FullName.ToLower() && position.ToLower() == employee.Position.ToLower() && salary == employee.Salary)
            {
                Console.WriteLine("Iscinin Yeni Vezifesini Daxil Et");
                string newPosition = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Iscinin Yeni Maashini Daxil Et");
                double NewSalary;
                string NewSalaryInput = Console.ReadLine();
                Console.WriteLine();
                while (!double.TryParse(NewSalaryInput, out NewSalary))
                {

                    Console.WriteLine();
                    Console.WriteLine("Reqem daxil edilmelidir!");
                    NewSalaryInput = Console.ReadLine();
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine("Axtarishiniza Uygun Ishci Yoxdur");
            }

        }
        static void RemoveEmployee(HumanResourceManager humanResourceManage) 
        { 
            Console.WriteLine("Silmek Istediyiniz Ishcinin Nomresini Daxil Edin");
            string no = Console.ReadLine();
            string departmentName= Console.ReadLine();
            humanResourceManage.RemoveEmployee(no,departmentName);


        }
    }
}
    
