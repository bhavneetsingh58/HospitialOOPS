using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    partial class Employee : Crud
    {
        public List<Employee> Emplist = new List<Employee>();
        /*{
            new Doctor(){EmpId=101,Name="Bhavneet"}, //,Dept="Dev"
            new Employee(){EmpId=102,Name="Singh"} //,Dept="Admin"
            //new Employee(){EmpID=103,Name="Sachdev",Dept="HR"}
        };*/

        //List<Employee> Emplist { get => emplist; set => emplist = value; }

        public void Add(Employee emp)
        {
           // Employee emp = new Doctor();
            Console.WriteLine("To add Doctor enter Info");
            emp.EmpId = int.Parse(Console.ReadLine());
            emp.Name = Console.ReadLine();
            emp.Emplist.Add(emp);

        }

        public void Display()
        {
            foreach (var em in Emplist)
            {
                Console.WriteLine("{0} {1}", em.EmpId, em.Name); //, em.Dept
            }
        }

        public void Remove()
        {
            Console.WriteLine("To remove Doctor Enter Doctor id");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (var em in Emplist)
            {
                if (em.EmpId == input)
                {
                    Emplist.Remove(em);
                    return;
                }
                else
                {
                    Console.WriteLine("User Not Found");
                    return;
                }
            }
        }
        /*public static void main()
        {
            Doctor c1 = new CrudClass();
            Employee e5 = new Doctor();
            e5.EmpId = 103;
            e5.Name = "gg";
            c1.Emplist.Add(e5); 


            c1.Display();
            Console.WriteLine("------------------------------------");
            c1.Remove();
            Console.WriteLine("------------------------------------");
            c1.Display();
        }
        */
    }
}
