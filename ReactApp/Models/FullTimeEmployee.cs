using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    public class FullTimeEmployee : BaseEmployee
    {
        
        public int AnnualSalary { get; set; }

        //public string GetFullName()
        //{
        //    return this.FirstName + " " + LastName;
        //}

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

    }
}