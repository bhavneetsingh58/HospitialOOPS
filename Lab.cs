using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    class Lab : Rooms
    {
        private string labType;
        string SubjectOfResearch;

        public string LabType { get => labType; set => labType = value; }
    }
}
