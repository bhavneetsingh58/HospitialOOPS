using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    class Patient :Hospitial
    {
        private string name;
        long PhoneNumber;
        int Bill;
        bool insuarance;

        public string Name { get => name; set => name = value; }
        public bool Insuarance { get => insuarance; set => insuarance = value; }

        public void Admit(int Number)
        {
            //string RNo = "R" + Number.ToString();
            Rooms RNo = new Rooms() ;
            RNo.RoomNo = Number;
            Console.WriteLine(RNo.RoomNo);
        }


    }
}
