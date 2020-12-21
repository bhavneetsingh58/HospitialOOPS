using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    public class Person : Hospitial 
    {
        private string name;
        private int phoneNumber;
        private int age;

        public string Name { get => name; set => name = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Age { get => age; set => age = value; }
    }
}
