using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.Models
{
    interface ICustomer
    {

        //int ID;
        void Print();
        //{
        //    Console.WriteLine("Hello");
        //}

    }

    interface I2
    {
        void I2Method();
    }


    public class Customer : ICustomer, I2 // inheriting from multiple interfaces
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print(/*int Name*/)
        {
            Console.WriteLine("Interface Print Method");
        }
    }


    public class Program : Customer/*, Sample*/ // class cannot inherit from multiple classes, but note class can inherit multiple interfaces!!!!
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.Print();
        }
    }





    //interface inheritance chain example---------------------------------
    interface ICustomer1
    {

        //int ID;
        void Print1();
        //{
        //    Console.WriteLine("Hello");
        //}

    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }


    //    public class Customer2 : ICustomer2 //ICustomer 2 does not implement Print1!!
    //    {
    //        //public void Print1()
    //        //{
    //        //    Console.WriteLine("Interface Print1");
    //        //}

    //        public void Print2()
    //        {
    //            Console.WriteLine("Interface Print2");
    //        }
    //    }

    //    public class Program2 
    //    {
    //        public static void Main()
    //        {
    //            Customer2 C1 = new Customer2();
    //            C1.Print1(); //uncomment Print1 above and error goes away
    //            C1.Print2();


    //            //cannot create instance of interface, there is no implementation!
    //            ICustomer1 Cust = new ICustomer1();


    //            ICustomer1 Cust2 = new Customer2();
    //            Cust.Print1();
    //        }
    //    }



    //    class Sample
    //    {

    //    }

    //    //Explicit interface implementation-----------------------------

    //    interface I5
    //    {
    //        void InterfaceMethod();
    //    }

    //    interface I6
    //    {
    //        void InterfaceMethod();
    //    }

    //    public class Program3 : I5, I6
    //    {
    //        /*public*/ void I5.InterfaceMethod()
    //        {
    //            Console.WriteLine("I5 Interface Method");
    //        }
    //        void I6.InterfaceMethod() //note the interface call in front of InterfaceMethod!!
    //        {
    //            Console.WriteLine("I6 Interface Method");
    //        }
    //        public static void Main3()
    //        {
    //            Program3 P = new Program3(); //P is an object reference varibale pointing to Program3 object in memory
    //            //P.InterfaceMethod(); //doesn't contain definition for InterfaceMethod in Program3

    //            ((I5)P).InterfaceMethod(); // typecasting the P 
    //            ((I6)P).InterfaceMethod();

    //        }

    //        public static void Main4()
    //        {
    //             I5  i5 = new Program3();
    //            I6 i6 = new Program3();

    //            i5.InterfaceMethod();
    //            i6.InterfaceMethod();
    //        }


    //        public static void Main5()
    //        {
    //            Program3 P = new Program3();
    //            P.InterfaceMethod(); // uncomment I5 public access modifier and comment out "I5." from I5.InterfaceMethod() to invoke it normally. This will run I5 as default interface!!!! then if we want I6 as well we have to explicitly call it.

    //            ((I6)P).InterfaceMethod();


    //        }






}