using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    partial class Employee : Person, Department
    {

        private int empId;
        string deptName;
        public int EmpId { get => empId; set => empId = value; }
        string Department.DeptName { get => deptName; set => deptName = value; }


    }


}
