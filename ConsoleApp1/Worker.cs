using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Worker:Human
    {
        public float wage { get; set; }
        public float hoursWorked { get; set; }

        public float workersWage()
        {
            return wage / hoursWorked;
        }

    }
}
