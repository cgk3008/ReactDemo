using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ReactApp.Models
{
    public class InterviewQuestions
    {
        static void Main()
        {
            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = "string";  //this is a different type, so cannot convert from string to int.

            //in an Object array, we can store different types as objects.

            object[] array1 = new object[2];
            array1[0] = 1;
            array1[1] = "string";

            CustomerInt c = new CustomerInt();
            c.ID = 99;
            c.Name = "Craig";
            array1[2] = c;

            foreach (object obj in array1)
            {
                Console.WriteLine(obj);
            }


            ArrayList array2 = new ArrayList();
            array2.Add(1);
            array2.Add("string");
            CustomerInt d = new CustomerInt();
            d.ID = 97;
            d.Name = "Dua";
            array2.Add(d);

            foreach (object obj in array2)
            {
                Console.WriteLine(obj);
            }



            string[] employeeNames = new string[3];

            employeeNames[0] = "Mark";
            employeeNames[1] = "Matt";
            employeeNames[2] = "John";


            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelors";

            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";

            for(int i=0; i<jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(employeeNames[i]);
                Console.WriteLine("-----------");
                for (int j=0; j<innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }
        }

        class CustomerInt
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }

        }





    }
}