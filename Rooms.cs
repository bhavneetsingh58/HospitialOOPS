using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitialOOPS
{
    class Rooms : Hospitial
    {
        String RoomType;
        int Capacity;
        int roomNo;
        int DailyPrice;

        public int RoomNo { get => roomNo; set => roomNo = value; }

    }
}
