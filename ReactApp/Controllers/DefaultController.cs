using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }

    public class FullTimeEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

    }

    public class ContractEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }

    }

    class Program
    {
        public static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Craig",
                LastName = "Kilborn",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("------------");

            ContractEmployee ce = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Dua",
                LastName = "Lipa",
                HourlyPay = 150,
                TotalHoursWorked = 55,
            };

            Console.WriteLine(ce.GetFullName());
            Console.WriteLine(ce.GetMonthlySalary());

            Console.WriteLine("------------");

        }

    }


}