using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    public class ContractEmployee : BaseEmployee
    {
        //public int ID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        //public string GetFullName()
        //{
        //    return this.FirstName + " " + LastName;
        //}

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }


    }
}