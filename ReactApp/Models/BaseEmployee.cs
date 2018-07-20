using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    public abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int AnnualSalary { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        //public virtual int GetMonthlySalary()
        //{
        //    throw new NotImplementedException();
        //}

        public abstract int GetMonthlySalary(); //abstract method forces inherited (child) classes to implement GetMonthlySalary


        //public Customer()
        //{
        //    this._id = Guid.NewGuid();
        //}
        //private Guid _id;
        //public Guid ID
        //{
        //    get
        //    {
        //        return this._id;
        //    }
        //}




    }
}