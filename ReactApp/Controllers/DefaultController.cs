using ReactApp.Models;
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
            //Can't instantiate BaseEmployee since it's an abstract class!!! This prevents devs from accidently trying to use the abstract class when you really only want them to use it as a parent/base class for inheritence.
            //BaseEmployee be = new BaseEmployee()
            //{
            //    ID = 103,
            //    FirstName = "Dwayne",
            //    LastName = "Johnson"
            //};
            //Console.WriteLine(be.GetFullName());

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