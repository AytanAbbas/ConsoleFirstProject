
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using HumanResourceManager.Models;
using HumanResourceManager.Services;

namespace HumanResourceManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManagerr humanResourceManager = new HumanResourceManagerr();


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
                        humanResourceManager.ShowDepartments();
                        break;
                    case "1.2":
                        humanResourceManager.AddDepartment();
                        break;
                    case "1.3":
                        humanResourceManager.EditDepartaments();
                        break;
                    case "2.1":
                        humanResourceManager.ShowAllEmpoyees();
                        break;
                    case "2.2":
                        humanResourceManager.ShowEmployeesOfADepartment();
                        break;
                    case "2.3":
                        humanResourceManager.AddEmployee();
                        break;
                    case "2.4":
                        humanResourceManager.EditEmployee();
                        break;
                    case "2.5":
                        humanResourceManager.RemoveEmployee();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Secdiyiniz emeliyyat movcud deyil, tekrar secin!");
                        break;
                }


            } while (true);
        } 
         
       
    }
}

