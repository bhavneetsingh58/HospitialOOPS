using System;

namespace HospitialOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab l1 = new Lab();
            /*
            Hospitial h1 = new Hospitial();
            Console.WriteLine(h1.Name);
            Patient p1 = new Patient()
            {
                Name = "Random Patient"
            };
            Console.WriteLine(p1.Name);
            p1.Admit(101);
            */

            //Employee e1 = new Employee();
            //Console.WriteLine(e1.EmployeeOf());

            
            bool toRerun = true;
            int i = 0;
            int SwitchKey;
            Console.WriteLine("Enter 1 for Hospitial");
            Console.WriteLine("Enter 2 for Patient");
            Console.WriteLine("Enter 3 for Doctor");
            Console.WriteLine("Enter 4 for Rooms");
            Console.WriteLine("Enter 5 for Lab");
            Console.WriteLine("----------------------");
            do
            {
                SwitchKey = Convert.ToInt32(Console.ReadLine());
                switch (SwitchKey)
                {
                    case 1: //Hospitial
                        Console.WriteLine("Hospitial Name is ");
                        break;

                    case 2: //Patient

                        break;
                    case 3:
                        //Employee/Doctor
                        Employee d1 = new Doctor();
                        d1.EmpId = 101;
                        d1.Name = "Bhavneet";
                        d1.Emplist.Add(d1);


                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Doctors Info");
                        d1.Display();
                        Console.WriteLine("------------------------------------");

                        d1.Add(d1);
                        Console.WriteLine("------------------------------------");
                        d1.Display();

                        d1.Remove();
                        Console.WriteLine("------------------------------------");
                        d1.Display();

                        break;
                    case 4:
                        //Rooms
                        break;
                    case 5:
                        //Labs
                        break;
                    default:
                        //Default
                        break;
                }
                i++;
            } while (toRerun);
            

            /*
            Employee e1 = new Doctor();
            e1.Age=10;
            Console.WriteLine(e1.Age);

            Employee e2 = new Nurse();
            e2.Age = 10;
            Console.WriteLine(e1.Age);
            */

            //CrudClass.main();
            
            Console.ReadLine();
        }
    }
}


